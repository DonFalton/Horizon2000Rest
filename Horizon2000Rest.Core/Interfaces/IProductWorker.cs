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
        /// <returns>The ProductDbo object representing the product.</returns>
        ProductDbo GetProduct(int id);

        /// <summary>
        /// Adds a new product.
        /// </summary>
        /// <param name="productDto">The AddProductDto object containing the product data.</param>
        /// <returns>The ProductDbo object representing the added product.</returns>
        ProductDbo AddProduct(AddProductDto productDto);

        /// <summary>
        /// Updates an existing product.
        /// </summary>
        /// <param name="productDto">The UpdateProductDto object containing the updated product data.</param>
        /// <returns>The ProductDbo object representing the updated product.</returns>
        ProductDbo UpdateProduct(UpdateProductDto productDto);
    }
}
