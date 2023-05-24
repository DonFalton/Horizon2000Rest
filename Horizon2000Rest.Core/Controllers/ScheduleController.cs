using AutoMapper;
using Horizon2000Rest.Core.Interfaces;
using Horizon2000Rest.Core.Models.Schedule;
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
    }
}
