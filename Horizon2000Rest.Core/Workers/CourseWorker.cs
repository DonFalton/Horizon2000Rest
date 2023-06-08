using AutoMapper;
using Horizon2000Rest.Core.Interfaces;
using Horizon2000Rest.Core.Models.Course;
using Horizon2000Rest.Entity.Data;
using Horizon2000Rest.Entity.Interfaces;
using Horizon2000Rest.Entity.Models;

namespace Horizon2000Rest.Core.Workers
{
    /// <summary>
    /// Implementation of the ICourseWorker interface for managing course operations.
    /// </summary>
    public class CourseWorker : ICourseWorker
    {
        private readonly DataContext _dataContext;
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;

        public CourseWorker(DataContext dataContext, ICourseRepository courseRepository, IMapper mapper)
        {
            _dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
            _courseRepository = courseRepository ?? throw new ArgumentNullException(nameof(courseRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <inheritdoc/>
        public GetCourseDto GetCourse(int id)
        {
            var courseDbo = _courseRepository.Get(id);
            return _mapper.Map<GetCourseDto>(courseDbo);
        }

        /// <inheritdoc/>
        public int AddCourse(CreateCourseDto course)
        {
            if (course == null)
                throw new ArgumentNullException(nameof(course));

            var courseDbo = _mapper.Map<CourseDbo>(course);

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

        /// <inheritdoc/>
        public void UpdateCourse(UpdateCourseDto updateCourseDto)
        {
            var courseDbo = _courseRepository.Get(updateCourseDto.Id);

            if (courseDbo == null)
                throw new ArgumentNullException($"Course with id {updateCourseDto.Id} not found");

            courseDbo.ImagePath = updateCourseDto.Image; // Suponiendo que esto es lo que quieres actualizar

            _courseRepository.Update(courseDbo);
            _dataContext.SaveChanges();
        }
    }
}
