using Horizon2000Rest.Core.Models.Course;

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
        /// <returns>The GetCourseDto object if found, or null if not found.</returns>
        GetCourseDto GetCourse(int id);

        /// <summary>
        /// Adds a new course.
        /// </summary>
        /// <param name="courseDto">The CreateCourseDto object containing the course data.</param>
        /// <returns>The ID of the added course.</returns>
        int AddCourse(CreateCourseDto courseDto);

        /// <summary>
        /// Updates an existing course.
        /// </summary>
        /// <param name="updateCourseDto">The UpdateCourseDto object containing the updated course data.</param>
        void UpdateCourse(UpdateCourseDto updateCourseDto);
    }
}
