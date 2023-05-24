using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;using System;
using System.Collections.Generic;

namespace Horizon2000Rest.Entity.Models
{
    /// <summary>
    /// Represents a user entity.
    /// </summary>
    [Table("User")]
    public class UserDbo
    {
        /// <summary>
        /// Gets or sets the ID of the user.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the surname of the user.
        /// </summary>
        [Required]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets the username of the user.
        /// </summary>
        [Required]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets the password of the user.
        /// </summary>
        [Required]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the email of the user.
        /// </summary>
        [Required]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the user was registered.
        /// </summary>
        [Required]
        public DateTime DateRegistered { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets or sets a value indicating whether the user is active.
        /// </summary>
        [Required]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the related UserRole entities.
        /// </summary>
        public virtual ICollection<UserRoleDbo> UserRoles { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the related UserSession entities.
        /// </summary>
        public virtual ICollection<UserSessionDbo> UserSessions { get; set; }
    }
}
