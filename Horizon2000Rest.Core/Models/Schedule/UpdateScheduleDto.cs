namespace Horizon2000Rest.Core.Models.Schedule
{
    /// <summary>
    /// Data transfer object for updating a schedule.
    /// Inherits from BaseScheduleDto.
    /// </summary>
    public class UpdateScheduleDto : BaseScheduleDto
    {
        /// <summary>
        /// Gets or sets the ID of the schedule.
        /// </summary>
        public int Id { get; set; }
    }
}
