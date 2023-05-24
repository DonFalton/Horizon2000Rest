using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon2000Rest.Entity.Models
{
    /// <summary>
    /// Represents an advertisement entity.
    /// </summary>
    [Table("Advert")]
    public class AdvertDbo
    {
        /// <summary>
        /// Gets or sets the ID of the advertisement.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the path of the advertisement.
        /// </summary>
        [Required]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the advertisement was created.
        /// </summary>
        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets or sets a value indicating whether the advertisement is active.
        /// </summary>
        [Required]
        public bool IsActive { get; set; }
    }
}
