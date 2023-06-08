using AutoMapper;
using Horizon2000Rest.Core.Interfaces;
using Horizon2000Rest.Core.Models.Course;
using Horizon2000Rest.Entity.Data;
using Horizon2000Rest.Entity.Interfaces;
using Horizon2000Rest.Entity.Models;
using Microsoft.AspNetCore.Mvc;

namespace Horizon2000Rest.Controllers
{
    /// <summary>
    /// Controller for managing courses.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly DataContext _dataContext;
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the CourseController class.
        /// </summary>
        /// <param name="dataContext">The DataContext instance for accessing the database.</param>
        /// <param name="courseRepository">The ICourseRepository instance for course operations.</param>
        /// <param name="mapper">The IMapper instance for object mapping.</param>
        public CourseController(DataContext dataContext, ICourseRepository courseRepository, IMapper mapper)
        {
            _dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
            _courseRepository = courseRepository ?? throw new ArgumentNullException(nameof(courseRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// Retrieves a course by ID.
        /// </summary>
        /// <param name="id">The ID of the course to retrieve.</param>
        /// <returns>The GetCourseDto containing the course details if found, or NotFound if not found.</returns>
        [HttpGet("{id}")]
        public GetCourseDto GetCourse(int id)
        {
            var courseDbo = _courseRepository.Get(id);
            return _mapper.Map<GetCourseDto>(courseDbo);
        }

        /// <summary>
        /// Adds a new course.
        /// </summary>
        /// <param name="courseDto">The CreateCourseDto containing the course data to add.</param>
        /// <returns>The ID of the created course if successful, or throws an exception if unsuccessful.</returns>
        [HttpPost]
        public int AddCourse(CreateCourseDto courseDto)
        {
            if (courseDto == null)
                throw new ArgumentNullException(nameof(courseDto));

            var courseDbo = _mapper.Map<CourseDbo>(courseDto);

            using (var transaction = _dataContext.Database.BeginTransaction())
            {
                try
                {
                    _courseRepository.Add(courseDbo);
                    _dataContext.SaveChanges();
                    transaction.Commit();

                    return courseDbo.ID;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error adding course", ex);
                }
            }
        }

        /// <summary>
        /// Updates an existing course.
        /// </summary>
        /// <param name="id">The ID of the course to update.</param>
        /// <param name="updateCourseDto">The UpdateCourseDto containing the course data to update.</param>
        /// <returns>The IActionResult indicating the result of the operation.</returns>
        [HttpPut("{id}")]
        public IActionResult UpdateCourse(int id, UpdateCourseDto updateCourseDto)
        {
            if (updateCourseDto == null)
                throw new ArgumentNullException(nameof(updateCourseDto));

            var existingCourseDbo = _courseRepository.Get(id);
            if (existingCourseDbo == null)
                return NotFound();

            // Update the image path of the existing course
            existingCourseDbo.ImagePath = updateCourseDto.Image;

            _courseRepository.Update(existingCourseDbo);
            _dataContext.SaveChanges();

            return NoContent();
        }
    }
}
