using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon2000Rest.Entity.Models
{
    [Table("UserRole")]
    public class UserRoleDbo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int RoleId { get; set; }

        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        [Required]
        public bool Active { get; set; }

        public virtual RoleDbo Role { get; set; }

        public virtual UserDbo User { get; set; }

    }
}
