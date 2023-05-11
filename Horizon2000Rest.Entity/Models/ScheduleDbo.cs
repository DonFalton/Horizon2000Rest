using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon2000Rest.Entity.Models
{
    [Table("Schedule")]
    public class ScheduleDbo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public int CourseId { get; set; }

        [Required]
        public DateTime StartDate { get; set; } = DateTime.Now;

        [Required]
        public int Duration { get; set; }

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public bool Active { get; set; }

        [Required]
        public string Title { get; set; }

        public virtual ICollection<BookingDbo> Bookings { get; set; }

        public virtual CourseDbo Course { get; set; }

    }
}
