using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon2000Rest.Entity.Models
{
    /// <summary>
    /// Represents a client entity.
    /// </summary>
    [Table("Client")]
    public class ClientDbo
    {
        /// <summary>
        /// Gets or sets the ID of the client.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the name of the client.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the surname of the client.
        /// </summary>
        [Required]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets the house number of the client (nullable).
        /// </summary>
        public string? HouseNumber { get; set; }

        /// <summary>
        /// Gets or sets the house name of the client (nullable).
        /// </summary>
        public string? HouseName { get; set; }

        /// <summary>
        /// Gets or sets the street of the client.
        /// </summary>
        [Required]
        public string Street { get; set; }

        /// <summary>
        /// Gets or sets the locality of the client.
        /// </summary>
        [Required]
        public string Locality { get; set; }

        /// <summary>
        /// Gets or sets the contact number of the client.
        /// </summary>
        [Required]
        public string ContactNo { get; set; }

        /// <summary>
        /// Gets or sets the VAT number of the client (nullable).
        /// </summary>
        public string? VatNo { get; set; }

        /// <summary>
        /// Gets or sets the email address of the client.
        /// </summary>
        [EmailAddress]
        public string? Email { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the client is active.
        /// </summary>
        [Required]
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Gets or sets the date and time when the client was created.
        /// </summary>
        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets or sets the navigation property for the related Repair entities.
        /// </summary>
        public virtual List<RepairDbo> Repairs { get; set; }
    }
}
