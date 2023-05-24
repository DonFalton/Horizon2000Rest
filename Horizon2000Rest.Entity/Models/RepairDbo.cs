using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon2000Rest.Entity.Models
{
    /// <summary>
    /// Represents a repair entity.
    /// </summary>
    [Table("Repair")]
    public class RepairDbo
    {
        /// <summary>
        /// Gets or sets the ID of the repair.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the client ID for the repair.
        /// </summary>
        [Required]
        public int ClientId { get; set; }

        /// <summary>
        /// Gets or sets the complaint related to the repair.
        /// </summary>
        [Required]
        public string Complaint { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the repair is active. Default is true.
        /// </summary>
        [Required]
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Gets or sets the date and time when the repair was created.
        /// </summary>
        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets or sets the navigation property for the related Client entity.
        /// </summary>
        public virtual ClientDbo Client { get; set; }
    }
}
