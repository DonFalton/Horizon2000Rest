using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon2000Rest.Entity.Models
{
    /// <summary>
    /// Represents a course entity.
    /// </summary>
    [Table("Course")]
    public class CourseDbo
    {
        /// <summary>
        /// Gets or sets the ID of the course.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the name of the course.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description of the course.
        /// </summary>
        [Required]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the normal hours for the course.
        /// </summary>
        [Required]
        public byte NormalHour { get; set; }

        /// <summary>
        /// Gets or sets the normal price for the course.
        /// </summary>
        [Required]
        public decimal NormalPrice { get; set; }

        /// <summary>
        /// Gets or sets the rapid hours for the course.
        /// </summary>
        [Required]
        public byte RapidHour { get; set; }

        /// <summary>
        /// Gets or sets the rapid price for the course.
        /// </summary>
        [Required]
        public decimal RapidPrice { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the course is active.
        /// </summary>
        [Required]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the course was created.
        /// </summary>
        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets or sets the ID of the parent course.
        /// </summary>
        [Required]
        public int ParentCourseId { get; set; }

        /// <summary>
        /// Gets or sets the path of the course image.
        /// </summary>
        [Required]
        public string ImagePath { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the related ParentCourse entity.
        /// </summary>
        public virtual ParentCourseDbo ParentCourse { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the related Schedule entities.
        /// </summary>
        public virtual ICollection<ScheduleDbo> Schedules { get; set; }
    }
}
