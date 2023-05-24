using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon2000Rest.Entity.Models
{
    /// <summary>
    /// Represents a role entity.
    /// </summary>
    [Table("Role")]
    public class RoleDbo
    {
        /// <summary>
        /// Gets or sets the ID of the role.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the name of the role.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the role was created.
        /// </summary>
        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets or sets a value indicating whether the role is active.
        /// </summary>
        [Required]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the related UserRole entities.
        /// </summary>
        public virtual ICollection<UserRoleDbo> UserRoles { get; set; }
    }
}
