namespace Horizon2000Rest.Core.Models.Course
{
    /// <summary>
    /// Data transfer object for retrieving a course.
    /// </summary>
    public class GetCourseDto
    {
        /// <summary>
        /// Gets or sets the ID of the course.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the course.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the image data of the course.
        /// </summary>
        public byte[] Image { get; set; }

        /// <summary>
        /// Gets or sets the file type of the course image.
        /// </summary>
        public string ImageFileType { get; set; }
    }
}
