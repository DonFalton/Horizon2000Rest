using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon2000Rest.Entity.Models
{
    [Table("UserSession")]
    public class UserSessionDbo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public string Session { get; set; }

        [Required]
        public DateTime DateExpire { get; set; }

        [Required]
        public bool Active { get; set; }

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        public virtual UserDbo User { get; set; }

    }
}
