namespace Horizon2000Rest.Core.Models.Course
{
    /// <summary>
    /// Data transfer object for retrieving the full detail of a course.
    /// Inherits from BaseCourseDto.
    /// </summary>
    public class GetCourseFullDetailDto : BaseCourseDto
    {
        /// <summary>
        /// Gets or sets the ID of the course.
        /// </summary>
        public int Id { get; set; }
    }
}
