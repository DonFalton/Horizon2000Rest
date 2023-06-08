using Horizon2000Rest.Core.Interfaces;
using Horizon2000Rest.Entity.Data;
using Horizon2000Rest.Entity.Interfaces;
using Horizon2000Rest.Entity.Models;

namespace Horizon2000Rest.Core.Workers
{
    /// <summary>
    /// Implementation of the IParentCourseWorker interface for managing parent course operations.
    /// </summary>
    public class ParentCourseWorker : IParentCourseWorker
    {
        private readonly DataContext _dataContext;
        private readonly IParentCourseRepository _parentCourseRepository;

        public ParentCourseWorker(DataContext dataContext, IParentCourseRepository parentCourseRepository)
        {
            _dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
            _parentCourseRepository = parentCourseRepository ?? throw new ArgumentNullException(nameof(parentCourseRepository));
        }

        /// <inheritdoc/>
        public ParentCourseDbo GetParentCourse(int id)
        {
            return _parentCourseRepository.Get(id);
        }

        public void AddParentCourse(ParentCourseDbo parentCourse)
        {
            _parentCourseRepository.Add(parentCourse);
        }

        public void UpdateParentCourse(ParentCourseDbo parentCourse)
        {
            _parentCourseRepository.Update(parentCourse);
        }
    }
}