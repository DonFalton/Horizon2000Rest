namespace Horizon2000Rest.Core.Models.Course
{
    /// <summary>
    /// Data transfer object for updating a course.
    /// </summary>
    public class UpdateCourseDto
    {
        /// <summary>
        /// Gets or sets the ID of the course.
        /// </summary>
        public int Id { get; set; }

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
