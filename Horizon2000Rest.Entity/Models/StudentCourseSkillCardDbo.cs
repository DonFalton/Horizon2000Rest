using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon2000Rest.Entity.Models
{
    /// <summary>
    /// Represents a student course skill card entity.
    /// </summary>
    [Table("StudentCourseSkillCard")]
    public class StudentCourseSkillCardDbo
    {
        /// <summary>
        /// Gets or sets the ID of the student course skill card.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the ID of the parent course associated with the student course skill card.
        /// </summary>
        [Required]
        public int ParentCourseID { get; set; }

        /// <summary>
        /// Gets or sets the ID of the student associated with the student course skill card.
        /// </summary>
        [Required]
        public int StudentID { get; set; }

        /// <summary>
        /// Gets or sets the skill card associated with the student course skill card.
        /// </summary>
        [Required]
        public string SkillCard { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the student course skill card was created.
        /// </summary>
        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets or sets a value indicating whether the student course skill card is active.
        /// </summary>
        [Required]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the related ParentCourse entity.
        /// </summary>
        public virtual ParentCourseDbo ParentCourse { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the related Student entity.
        /// </summary>
        public virtual StudentDbo Student { get; set; }
    }
}
