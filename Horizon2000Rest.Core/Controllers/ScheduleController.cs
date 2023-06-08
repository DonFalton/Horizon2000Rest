using AutoMapper;
using Horizon2000Rest.Core.Interfaces;
using Horizon2000Rest.Core.Models.Schedule;
using Horizon2000Rest.Entity.Models;
using Microsoft.AspNetCore.Mvc;

namespace Horizon2000Rest.Controllers
{
    /// <summary>
    /// Controller for managing schedules.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ScheduleController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IScheduleWorker _scheduleWorker;

        public ScheduleController(IMapper mapper, IScheduleWorker scheduleWorker)
        {
            _mapper = mapper;
            _scheduleWorker = scheduleWorker;
        }

        /// <summary>
        /// Retrieves all schedules.
        /// </summary>
        /// <returns>A list of schedule DTOs.</returns>
        [HttpGet]
        public IActionResult GetAllSchedules()
        {
            var schedules = _scheduleWorker.GetAllSchedules();
            var scheduleDtos = _mapper.Map<List<GetScheduleDto>>(schedules);
            return Ok(scheduleDtos);
        }

        /// <summary>
        /// Retrieves a schedule by ID.
        /// </summary>
        /// <param name="id">The ID of the schedule.</param>
        /// <returns>The schedule DTO.</returns>
        [HttpGet("{id}")]
        public IActionResult GetSchedule(int id)
        {
            var scheduleDbo = _scheduleWorker.GetSchedule(id);
            if (scheduleDbo == null)
            {
                return NotFound();
            }

            var scheduleDto = _mapper.Map<GetScheduleDto>(scheduleDbo);
            return Ok(scheduleDto);
        }
        [HttpPost]
        public IActionResult AddSchedule([FromBody] AddScheduleDto scheduleDto)
        {
            var scheduleDbo = _mapper.Map<ScheduleDbo>(scheduleDto);
            _scheduleWorker.AddSchedule(scheduleDbo);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateSchedule(int id, [FromBody] UpdateScheduleDto scheduleDto)
        {
            var existingSchedule = _scheduleWorker.GetSchedule(id);
            if (existingSchedule == null)
            {
                return NotFound();
            }

            var scheduleDbo = _mapper.Map<ScheduleDbo>(scheduleDto);
            scheduleDbo.ID = id; // Ensure the ID is set correctly

            _scheduleWorker.UpdateSchedule(scheduleDbo);
            return Ok();
        }

    }
}
