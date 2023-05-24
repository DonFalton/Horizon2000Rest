using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon2000Rest.Entity.Models
{
    /// <summary>
    /// Represents a booking entity.
    /// </summary>
    [Table("Booking")]
    public class BookingDbo
    {
        /// <summary>
        /// Gets or sets the ID of the booking.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the ID of the schedule associated with the booking.
        /// </summary>
        [Required]
        public int ScheduleId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the student associated with the booking.
        /// </summary>
        [Required]
        public int StudentId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the booking has been paid.
        /// </summary>
        [Required]
        public bool Paid { get; set; }

        /// <summary>
        /// Gets or sets the payment type of the booking (nullable).
        /// </summary>
        public short? PaymentType { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the booking is complete.
        /// </summary>
        [Required]
        public bool Complete { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the booking was created.
        /// </summary>
        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets or sets a value indicating whether the booking is active.
        /// </summary>
        [Required]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the skill card number associated with the booking.
        /// </summary>
        public string SkillCardNo { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the related Student entity.
        /// </summary>
        public virtual StudentDbo Student { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the related Schedule entity.
        /// </summary>
        public virtual ScheduleDbo Schedule { get; set; }
    }
}
