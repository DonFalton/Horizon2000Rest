using Horizon2000Rest.Core.Models.Product;
using Horizon2000Rest.Entity.Models;

namespace Horizon2000Rest.Core.Interfaces
{
    /// <summary>
    /// Interface for managing product operations.
    /// </summary>
    public interface IProductWorker
    {
        /// <summary>
        /// Retrieves a product by ID.
        /// </summary>
        /// <param name="id">The ID of the product.</param>
        /// <returns>The product entity.</returns>
        ProductDbo GetProduct(int id);
        ProductDbo AddProduct(AddProductDto productDto);
        ProductDbo UpdateProduct(UpdateProductDto productDto);
    }
}