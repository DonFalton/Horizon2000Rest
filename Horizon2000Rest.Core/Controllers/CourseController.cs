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
    public class CourseWorker : ICourseWorker
    {
        private readonly DataContext _dataContext;
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the CourseController class.
        /// </summary>
        /// <param name="mapper">The IMapper instance for object mapping.</param>
        /// <param name="courseWorker">The ICourseWorker instance for course operations.</param>
        public CourseWorker(DataContext dataContext, ICourseRepository courseRepository, IMapper mapper)
        {
            _dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
            _courseRepository = courseRepository ?? throw new ArgumentNullException(nameof(courseRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// Retrieves a course by ID.
        /// </summary>
        /// <param name="id">The ID of the course to retrieve.</param>
        /// <returns>The ActionResult containing the course details if found, or NotFound if not found.</returns>
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
        /// <returns>The ActionResult containing the created course details if successful, or an error response if unsuccessful.</returns>
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

    }
}
