using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon2000Rest.Entity.Models
{
    [Table("User")]
    public class UserDbo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public DateTime DateRegistered { get; set; } = DateTime.Now;

        [Required]
        public bool Active { get; set; }

        public virtual ICollection<UserRoleDbo> UserRoles { get; set; }

        public virtual ICollection<UserSessionDbo> UserSessions { get; set; }

    }
}
