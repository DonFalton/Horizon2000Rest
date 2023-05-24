namespace Horizon2000Rest.Core.Models.Course
{
    /// <summary>
    /// Data transfer object for retrieving a list of courses.
    /// </summary>
    public class GetCourseListDto
    {
        /// <summary>
        /// Gets or sets the ID of the course.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the course.
        /// </summary>
        public string Name { get; set; }
    }
}
