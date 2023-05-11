using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon2000Rest.Entity.Models
{
    [Table("Role")]
    public class RoleDbo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<UserRoleDbo> UserRoles { get; set; }

    }
}
