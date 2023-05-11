using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon2000Rest.Entity.Models
{
    [Table("ParentCourse")]
    public class ParentCourseDbo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ImagePath { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        public string? TestConditions { get; set; }

        public Nullable<decimal> SkillCardCost { get; set; }


        public virtual ICollection<StudentCourseSkillCardDbo> StudentCourseSkillCards { get; set; }

        public virtual ICollection<CourseDbo> Courses { get; set; }

    }
}
