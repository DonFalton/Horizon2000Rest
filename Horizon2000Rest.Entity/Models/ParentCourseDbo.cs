using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon2000Rest.Entity.Models
{
    /// <summary>
    /// Represents a parent course entity.
    /// </summary>
    [Table("ParentCourse")]
    public class ParentCourseDbo
    {
        /// <summary>
        /// Gets or sets the ID of the parent course.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the name of the parent course.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the image path of the parent course.
        /// </summary>
        [Required]
        public string ImagePath { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the parent course is active.
        /// </summary>
        [Required]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the parent course was created.
        /// </summary>
        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets or sets the test conditions for the parent course (nullable).
        /// </summary>
        public string? TestConditions { get; set; }

        /// <summary>
        /// Gets or sets the cost of the skill card for the parent course (nullable).
        /// </summary>
        public Nullable<decimal> SkillCardCost { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the related StudentCourseSkillCard entities.
        /// </summary>
        public virtual ICollection<StudentCourseSkillCardDbo> StudentCourseSkillCards { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the related Course entities.
        /// </summary>
        public virtual ICollection<CourseDbo> Courses { get; set; }
    }
}
