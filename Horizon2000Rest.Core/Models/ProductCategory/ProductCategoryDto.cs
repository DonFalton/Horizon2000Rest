namespace Horizon2000Rest.Core.Models.ProductCategory
{
    /// <summary>
    /// Data transfer object for a product category.
    /// </summary>
    public class ProductCategoryDto
    {
        /// <summary>
        /// Gets or sets the ID of the product category.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the product category.
        /// </summary>
        public string Name { get; set; }
    }
}
