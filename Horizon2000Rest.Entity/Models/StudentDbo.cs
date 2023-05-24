using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon2000Rest.Entity.Models
{
    /// <summary>
    /// Represents a student entity.
    /// </summary>
    [Table("Student")]
    public class StudentDbo
    {
        /// <summary>
        /// Gets or sets the ID of the student.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the ID card of the student.
        /// </summary>
        [Required]
        public string IdCard { get; set; }

        /// <summary>
        /// Gets or sets the title of the student.
        /// </summary>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the name of the student.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the surname of the student.
        /// </summary>
        [Required]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets the address line 1 of the student.
        /// </summary>
        [Required]
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or sets the address line 2 of the student.
        /// </summary>
        [Required]
        public string Address2 { get; set; }

        /// <summary>
        /// Gets or sets the city of the student.
        /// </summary>
        [Required]
        public string City { get; set; }

        /// <summary>
        /// Gets or sets the postcode of the student (nullable).
        /// </summary>
        public string? Postcode { get; set; }

        /// <summary>
        /// Gets or sets the email of the student.
        /// </summary>
        [Required]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the contact number of the student (nullable).
        /// </summary>
        public string? ContactNo { get; set; }

        /// <summary>
        /// Gets or sets the date of birth of the student.
        /// </summary>
        [Required]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the student was created.
        /// </summary>
        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets or sets a value indicating whether the student is active.
        /// </summary>
        [Required]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the related Booking entities.
        /// </summary>
        public ICollection<BookingDbo> Bookings { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the related StudentCourseSkillCard entities.
        /// </summary>
        public ICollection<StudentCourseSkillCardDbo> StudentCourseSkillCard { get; set; }
    }
}
