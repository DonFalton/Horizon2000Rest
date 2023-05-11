using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon2000Rest.Entity.Models
{
    [Table("StudentCourseSkillCard")]
    public class StudentCourseSkillCardDbo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public int ParentCourseID { get; set; }

        [Required]
        public int StudentID { get; set; }

        [Required]
        public string SkillCard { get; set; }

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public bool Active { get; set; }

        public virtual ParentCourseDbo ParentCourse { get; set; }

        public virtual StudentDbo Student { get; set; }


    }
}
