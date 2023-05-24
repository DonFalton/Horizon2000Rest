namespace Horizon2000Rest.Core.Models.ProductCategory
{
    /// <summary>
    /// Data transfer object for updating a product category.
    /// </summary>
    public class UpdateProductCategoryDto
    {
        /// <summary>
        /// Gets or sets the ID of the product category.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the updated name of the product category.
        /// </summary>
        public string Name { get; set; }
    }
}
