using Horizon2000Rest.Entity.Models;

namespace Horizon2000Rest.Core.Interfaces
{
    /// <summary>
    /// Interface for managing course operations.
    /// </summary>
    public interface ICourseWorker
    {
        /// <summary>
        /// Retrieves a course by ID.
        /// </summary>
        /// <param name="id">The ID of the course to retrieve.</param>
        /// <returns>The CourseDbo object if found, or null if not found.</returns>
        CourseDbo GetCourse(int id);

        /// <summary>
        /// Adds a new course.
        /// </summary>
        /// <param name="course">The CourseDbo object containing the course data.</param>
        /// <returns>The ID of the added course.</returns>
        int AddCourse(CourseDbo course);
    }
}
