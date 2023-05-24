using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon2000Rest.Entity.Models
{
    /// <summary>
    /// Represents a schedule entity.
    /// </summary>
    [Table("Schedule")]
    public class ScheduleDbo
    {
        /// <summary>
        /// Gets or sets the ID of the schedule.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the course ID associated with the schedule.
        /// </summary>
        [Required]
        public int CourseId { get; set; }

        /// <summary>
        /// Gets or sets the start date of the schedule.
        /// </summary>
        [Required]
        public DateTime StartDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets or sets the duration of the schedule.
        /// </summary>
        [Required]
        public int Duration { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the schedule was created.
        /// </summary>
        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets or sets a value indicating whether the schedule is active.
        /// </summary>
        [Required]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the title of the schedule.
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the related Booking entities.
        /// </summary>
        public virtual ICollection<BookingDbo> Bookings { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the related Course entity.
        /// </summary>
        public virtual CourseDbo Course { get; set; }
    }
}
