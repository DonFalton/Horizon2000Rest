using AutoMapper;
using Horizon2000Rest.Core.Interfaces;
using Horizon2000Rest.Core.Models.ParentCourse;
using Horizon2000Rest.Entity.Models;
using Microsoft.AspNetCore.Mvc;

namespace Horizon2000Rest.Controllers
{
    /// <summary>
    /// Controller for managing parent courses.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ParentCourseController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IParentCourseWorker _parentCourseWorker;

        /// <summary>
        /// Initializes a new instance of the ParentCourseController class.
        /// </summary>
        /// <param name="mapper">The IMapper instance for object mapping.</param>
        /// <param name="parentCourseWorker">The IParentCourseWorker instance for parent course operations.</param>
        public ParentCourseController(IMapper mapper, IParentCourseWorker parentCourseWorker)
        {
            _mapper = mapper;
            _parentCourseWorker = parentCourseWorker;
        }

        /// <summary>
        /// Retrieves a parent course by ID.
        /// </summary>
        /// <param name="id">The ID of the parent course to retrieve.</param>
        /// <returns>The ActionResult containing the parent course details if found, or NotFound if not found.</returns>
        [HttpGet("{id}")]
        public IActionResult GetParentCourse(int id)
        {
            var parentCourseDbo = _parentCourseWorker.GetParentCourse(id);
            if (parentCourseDbo == null)
            {
                return NotFound();
            }

            var parentCourseDto = _mapper.Map<GetActiveParentCourseDto>(parentCourseDbo);
            return Ok(parentCourseDto);
        }

        [HttpPost]
        public IActionResult AddParentCourse([FromBody] AddParentCourseDto parentCourseDto)
        {
            var parentCourseDbo = _mapper.Map<ParentCourseDbo>(parentCourseDto);
            _parentCourseWorker.AddParentCourse(parentCourseDbo);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult UpdateParentCourse(int id, [FromBody] UpdateParentCourseDto parentCourseDto)
        {
            var parentCourseDbo = _parentCourseWorker.GetParentCourse(id);
            if (parentCourseDbo == null)
            {
                return NotFound();
            }

            _mapper.Map(parentCourseDto, parentCourseDbo);  // Assumes the Mapper is configured to do this
            _parentCourseWorker.UpdateParentCourse(parentCourseDbo);
            return NoContent();
        }
    }
}
