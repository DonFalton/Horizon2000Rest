using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon2000Rest.Entity.Models
{
    /// <summary>
    /// Represents a user role entity.
    /// </summary>
    [Table("UserRole")]
    public class UserRoleDbo
    {
        /// <summary>
        /// Gets or sets the ID of the user role.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the ID of the user associated with the user role.
        /// </summary>
        [Required]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the ID of the role associated with the user role.
        /// </summary>
        [Required]
        public int RoleId { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the user role was created.
        /// </summary>
        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets or sets a value indicating whether the user role is active.
        /// </summary>
        [Required]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the related Role entity.
        /// </summary>
        public virtual RoleDbo Role { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the related User entity.
        /// </summary>
        public virtual UserDbo User { get; set; }
    }
}
