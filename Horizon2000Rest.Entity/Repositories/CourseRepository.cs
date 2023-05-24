using Horizon2000Rest.Entity.Data;
using Horizon2000Rest.Entity.Interfaces;
using Horizon2000Rest.Entity.Models;

namespace Horizon2000REST.Entity.Repositories
{
    /// <inheritdoc/>
    /// <seealso cref="ICourseRepository"/>
    public class CourseRepository : ICourseRepository
    {
        /// <summary>
        /// Database context
        /// </summary>
        private readonly DataContext _dataContext;

        public CourseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Retrieves a CourseDbo object by its ID
        /// </summary>
        public CourseDbo Get(int id)
        {
            return _dataContext.Courses.FirstOrDefault(x => x.ID == id) ??
                throw new ArgumentNullException("Course not found");
        }

        /// <inheritdoc/>
        /// <summary>
        /// Finds a CourseDbo object by its ID
        /// </summary>
        public CourseDbo Find(int id) =>
            _dataContext.Courses.FirstOrDefault(x => x.ID == id);

        /// <inheritdoc/>
        /// <summary>
        /// Retrieves all active CourseDbo objects
        /// </summary>
        /// <inheritdoc/>
        // Retrieves all active CourseDbo objects
        public List<CourseDbo> GetAll() =>
            _dataContext.Courses
                .Where(x => x.IsActive)
                .ToList();

        /// <inheritdoc/>
        /// <summary>
        /// Updates a CourseDbo object
        /// </summary>
        public void Update(CourseDbo course)
        {
            _dataContext.Update(course);
        }

        /// <inheritdoc/>
        /// <summary>
        /// Deletes a CourseDbo object by setting IsActive to false
        /// </summary>
        public void Delete(int id)
        {
            var course = Get(id);
            course.IsActive = false;

            Update(course);
        }

        /// <inheritdoc/>
        /// <summary>
        /// Adds a new CourseDbo object
        /// </summary>
        public void Add(CourseDbo course)
        {
            _dataContext.Courses.Add(course);
        }
    }
}
