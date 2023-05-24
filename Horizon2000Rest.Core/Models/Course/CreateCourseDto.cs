namespace Horizon2000Rest.Core.Models.Course
{
    /// <summary>
    /// Data transfer object for creating a course.
    /// Inherits from BaseCourseDto.
    /// </summary>
    public class CreateCourseDto : BaseCourseDto
    {
        /// <summary>
        /// Gets or sets the image data of the course.
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets the file name of the course image.
        /// </summary>
        public string ImageFileName { get; set; }
    }
}
