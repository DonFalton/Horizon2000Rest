using AutoMapper;
using Horizon2000Rest.Core.Interfaces;
using Horizon2000Rest.Core.Models.Course;
using Horizon2000Rest.Entity.Models;
using Microsoft.AspNetCore.Mvc;

namespace Horizon2000Rest.Controllers
{
    /// <summary>
    /// Controller for managing courses.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICourseWorker _courseWorker;

        /// <summary>
        /// Initializes a new instance of the CourseController class.
        /// </summary>
        /// <param name="mapper">The IMapper instance for object mapping.</param>
        /// <param name="courseWorker">The ICourseWorker instance for course operations.</param>
        public CourseController(IMapper mapper, ICourseWorker courseWorker)
        {
            _mapper = mapper;
            _courseWorker = courseWorker;
        }

        /// <summary>
        /// Retrieves a course by ID.
        /// </summary>
        /// <param name="id">The ID of the course to retrieve.</param>
        /// <returns>The ActionResult containing the course details if found, or NotFound if not found.</returns>
        [HttpGet("{id}")]
        public IActionResult GetCourse(int id)
        {
            var courseDbo = _courseWorker.GetCourse(id);
            if (courseDbo == null)
            {
                return NotFound();
            }

            var courseDto = _mapper.Map<GetCourseDto>(courseDbo);
            return Ok(courseDto);
        }

        /// <summary>
        /// Adds a new course.
        /// </summary>
        /// <param name="courseDto">The CreateCourseDto containing the course data to add.</param>
        /// <returns>The ActionResult containing the created course details if successful, or an error response if unsuccessful.</returns>
        [HttpPost]
        public IActionResult AddCourse([FromBody] CreateCourseDto courseDto)
        {
            if (courseDto == null)
            {
                return BadRequest("Invalid course data");
            }

            try
            {
                var courseDbo = _mapper.Map<CourseDbo>(courseDto);
                var courseId = _courseWorker.AddCourse(courseDbo);

                return CreatedAtAction(nameof(GetCourse), new { id = courseId }, courseDto);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error adding course: {ex.Message}");
            }
        }
    }
}
