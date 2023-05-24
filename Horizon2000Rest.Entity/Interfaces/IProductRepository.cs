using Horizon2000Rest.Entity.Models;

namespace Horizon2000Rest.Entity.Interfaces
{
    public interface IProductRepository
    {
        /// <summary>
        /// Retrieves a ProductDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the product.</param>
        /// <returns>The ProductDbo entity.</returns>
        ProductDbo Get(int id);

        /// <summary>
        /// Finds a ProductDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the product.</param>
        /// <returns>The ProductDbo entity if found, otherwise null.</returns>
        ProductDbo Find(int id);

        /// <summary>
        /// Retrieves all ProductDbo entities.
        /// </summary>
        /// <returns>A list of ProductDbo entities.</returns>
        List<ProductDbo> GetAll();

        /// <summary>
        /// Updates an existing ProductDbo entity.
        /// </summary>
        /// <param name="advert">The ProductDbo entity to be updated.</param>
        void Update(ProductDbo advert);

        /// <summary>
        /// Deletes a ProductDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the product to be deleted.</param>
        void Delete(int id);

        /// <summary>
        /// Adds a new ProductDbo entity.
        /// </summary>
        /// <param name="advert">The ProductDbo entity to be added.</param>
        void Add(ProductDbo advert);
    }
}
