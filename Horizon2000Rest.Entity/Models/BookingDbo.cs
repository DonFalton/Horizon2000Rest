using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon2000Rest.Entity.Models
{
    [Table("Booking")]
    public class BookingDbo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public int ScheduleId { get; set; }

        [Required]
        public int StudentId { get; set; }

        [Required]
        public bool Paid { get; set; }

        public short? PaymentType { get; set; }

        [Required]
        public bool Complete { get; set; }

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public bool Active { get; set; }

        public string SkillCardNo { get; set; }


        public virtual StudentDbo Student { get; set; }

        public virtual ScheduleDbo Schedule { get; set; }

    }
}
