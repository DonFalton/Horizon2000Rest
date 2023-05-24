using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon2000Rest.Entity.Models
{
    /// <summary>
    /// Represents a user session entity.
    /// </summary>
    [Table("UserSession")]
    public class UserSessionDbo
    {
        /// <summary>
        /// Gets or sets the ID of the user session.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the ID of the user associated with the user session.
        /// </summary>
        [Required]
        public int UserId { get; set; }

        /// <summary>
        /// Gets or sets the session value of the user session.
        /// </summary>
        [Required]
        public string Session { get; set; }

        /// <summary>
        /// Gets or sets the expiration date and time of the user session.
        /// </summary>
        [Required]
        public DateTime DateExpire { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user session is active.
        /// </summary>
        [Required]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the user session was created.
        /// </summary>
        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets or sets the navigation property for the related User entity.
        /// </summary>
        public virtual UserDbo User { get; set; }
    }
}
