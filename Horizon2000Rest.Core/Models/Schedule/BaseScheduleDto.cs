namespace Horizon2000Rest.Core.Models.Schedule
{
    /// <summary>
    /// Base data transfer object for a schedule.
    /// </summary>
    public class BaseScheduleDto
    {
        /// <summary>
        /// Gets or sets the title of the schedule.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the ID of the course for the schedule.
        /// </summary>
        public int CourseID { get; set; }

        /// <summary>
        /// Gets or sets the start date of the schedule.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets the end date of the schedule.
        /// </summary>
        public DateTime EndDate { get; set; }
    }
}
