namespace Horizon2000Rest.Core.Models.Product
{
    /// <summary>
    /// Base data transfer object for a product.
    /// </summary>
    public class BaseProductDto
    {
        /// <summary>
        /// Gets or sets the name of the product.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the ID of the category to which the product belongs.
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// Gets or sets the price of the product.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the description of the product.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the image of the product.
        /// </summary>
        public string Image { get; set; }
    }
}
