namespace Horizon2000Rest.Core.Models.Course
{
    /// <summary>
    /// Data transfer object for a base course.
    /// </summary>
    public class BaseCourseDto
    {
        /// <summary>
        /// Gets or sets the name of the course.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the normal hours for the course.
        /// </summary>
        public int NormalHour { get; set; }

        /// <summary>
        /// Gets or sets the normal price for the course.
        /// </summary>
        public decimal NormalPrice { get; set; }

        /// <summary>
        /// Gets or sets the rapid hours for the course.
        /// </summary>
        public int RapidHour { get; set; }

        /// <summary>
        /// Gets or sets the rapid price for the course.
        /// </summary>
        public decimal RapidPrice { get; set; }

        /// <summary>
        /// Gets or sets the description of the course.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the ID of the parent course.
        /// </summary>
        public int ParentCourseId { get; set; }
    }
}
