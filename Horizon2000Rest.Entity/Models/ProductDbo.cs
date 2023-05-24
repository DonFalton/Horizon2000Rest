using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Horizon2000Rest.Entity.Models
{
    /// <summary>
    /// Represents a product entity.
    /// </summary>
    [Table("Product")]
    public class ProductDbo
    {
        /// <summary>
        /// Gets or sets the ID of the product.
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the category ID of the product.
        /// </summary>
        [Required]
        public int CategoryID { get; set; }

        /// <summary>
        /// Gets or sets the price of the product.
        /// </summary>
        [Required]
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the description of the product.
        /// </summary>
        [Required]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the image of the product.
        /// </summary>
        [Required]
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets the date and time when the product was created.
        /// </summary>
        [Required]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets or sets a value indicating whether the product is active.
        /// </summary>
        [Required]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets the navigation property for the related ProductCategory entity.
        /// </summary>
        public virtual ProductCategoryDbo ProductCategory { get; set; }
    }
}
