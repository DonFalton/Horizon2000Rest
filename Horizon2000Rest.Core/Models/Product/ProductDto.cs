namespace Horizon2000Rest.Core.Models.Product
{
    /// <summary>
    /// Data transfer object for a product.
    /// Inherits from BaseProductDto.
    /// </summary>
    public class ProductDto : BaseProductDto
    {
        /// <summary>
        /// Gets or sets the ID of the product.
        /// </summary>
        public int Id { get; set; }
    }
}
