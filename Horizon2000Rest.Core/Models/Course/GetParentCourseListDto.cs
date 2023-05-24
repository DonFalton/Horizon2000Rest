namespace Horizon2000Rest.Core.Models.Course
{
    /// <summary>
    /// Data transfer object for retrieving a list of parent courses.
    /// </summary>
    public class GetParentCourseListDto
    {
        /// <summary>
        /// Gets or sets the ID of the parent course.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the parent course.
        /// </summary>
        public string Name { get; set; }

        // The Courses property is commented out to avoid a warning.
        // Uncomment it if needed.
        // public List<GetCourseListDto> Courses { get; set; }
    }
}
