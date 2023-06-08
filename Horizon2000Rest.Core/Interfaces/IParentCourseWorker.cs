using Horizon2000Rest.Entity.Models;

namespace Horizon2000Rest.Core.Interfaces
{
    /// <summary>
    /// Interface for managing parent course operations.
    /// </summary>
    public interface IParentCourseWorker
    {
        /// <summary>
        /// Retrieves a parent course by ID.
        /// </summary>
        /// <param name="id">The ID of the parent course to retrieve.</param>
        /// <returns>The ParentCourseDbo object if found, or null if not found.</returns>
        ParentCourseDbo GetParentCourse(int id);

        /// <summary>
        /// Adds a new parent course.
        /// </summary>
        /// <param name="parentCourse">The ParentCourseDbo object to add.</param>
        void AddParentCourse(ParentCourseDbo parentCourse);

        /// <summary>
        /// Updates an existing parent course.
        /// </summary>
        /// <param name="parentCourse">The ParentCourseDbo object to update.</param>
        void UpdateParentCourse(ParentCourseDbo parentCourse);
    }
}