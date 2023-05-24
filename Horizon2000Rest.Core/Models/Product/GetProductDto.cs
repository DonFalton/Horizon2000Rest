namespace Horizon2000Rest.Core.Models.Product
{
    /// <summary>
    /// Data transfer object for retrieving a product.
    /// </summary>
    public class GetProductDto
    {
        // The Products property is commented out to avoid a warning.
        // Uncomment it if needed.
        // public List<ProductDbo> Products { get; set; }

        /// <summary>
        /// Gets or sets the value for the "Next" property.
        /// </summary>
        public int Next { get; set; }
    }
}
