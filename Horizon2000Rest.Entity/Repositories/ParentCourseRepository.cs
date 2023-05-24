using Horizon2000Rest.Entity.Data;
using Horizon2000Rest.Entity.Interfaces;
using Horizon2000Rest.Entity.Models;

namespace Horizon2000REST.Entity.Repositories
{
    /// <inheritdoc/>
    /// <seealso cref="IParentCourseRepository"/>
    public class ParentCourseRepository : IParentCourseRepository
    {
        /// <summary>
        /// Database context
        /// </summary>
        private readonly DataContext _dataContext;

        public ParentCourseRepository(DataContext horizonContext)
        {
            _dataContext = horizonContext;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Retrieves a ParentCourseDbo object by its ID
        /// </summary>
        public ParentCourseDbo Get(int id)
        {
            return _dataContext.ParentCourses.FirstOrDefault(x => x.ID == id) ??
                throw new ArgumentNullException("ParentCourse not found");
        }

        /// <inheritdoc/>
        /// <summary>
        /// Finds a ParentCourseDbo object by its ID
        /// </summary>
        public ParentCourseDbo Find(int id) =>
            _dataContext.ParentCourses.FirstOrDefault(x => x.ID == id);

        /// <inheritdoc/>
        /// <summary>
        /// Retrieves all active ParentCourseDbo objects
        /// </summary>
        public List<ParentCourseDbo> GetAll() =>
            _dataContext.ParentCourses
                .Where(x => x.IsActive)
                .ToList();

        /// <inheritdoc/>
        /// <summary>
        /// Updates a ParentCourseDbo object
        /// </summary>
        public void Update(ParentCourseDbo parentCourse)
        {
            _dataContext.Update(parentCourse);
        }

        /// <inheritdoc/>
        /// <summary>
        /// Deletes a ParentCourseDbo object by setting IsActive to false
        /// </summary>
        public void Delete(int id)
        {
            var parentCourse = Get(id);
            parentCourse.IsActive = false;

            Update(parentCourse);
        }

        /// <inheritdoc/>
        /// <summary>
        /// Adds a new ParentCourseDbo object
        /// </summary>
        public void Add(ParentCourseDbo parentCourse)
        {
            _dataContext.ParentCourses.Add(parentCourse);
        }
    }
}
