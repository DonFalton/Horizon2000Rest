using Horizon2000Rest.Core.Interfaces;
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

        public CourseWorker(DataContext dataContext, ICourseRepository courseRepository)
        {
            _dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
            _courseRepository = courseRepository ?? throw new ArgumentNullException(nameof(courseRepository));
        }

        /// <inheritdoc/>
        public CourseDbo GetCourse(int id)
        {
            return _courseRepository.Get(id);
        }

        /// <inheritdoc/>
        public int AddCourse(CourseDbo course)
        {
            if (course == null)
                throw new ArgumentNullException(nameof(course));

            using (var transaction = _dataContext.Database.BeginTransaction())
            {
                try
                {
                    _courseRepository.Add(course);
                    _dataContext.SaveChanges();
                    transaction.Commit();

                    return course.ID;
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