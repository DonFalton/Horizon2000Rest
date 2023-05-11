using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon2000Rest.Entity.Models
{
    [Table("Student")]
    public class StudentDbo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string IdCard { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string Address1 { get; set; }

        [Required]
        public string Address2 { get; set; }

        [Required]
        public string City { get; set; }

        public string? Postcode { get; set; }

        [Required]
        public string Email { get; set; }


        public string? ContactNo { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public bool IsActive { get; set; }

        public ICollection<BookingDbo> Bookings { get; set; }

        public ICollection<StudentCourseSkillCardDbo> StudentCourseSkillCard { get; set; }



    }
}
