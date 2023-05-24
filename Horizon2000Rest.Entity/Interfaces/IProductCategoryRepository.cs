using Horizon2000Rest.Entity.Models;

namespace Horizon2000Rest.Entity.Interfaces
{
    public interface IProductCategoryRepository
    {
        /// <summary>
        /// Retrieves a ProductCategoryDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the product category.</param>
        /// <returns>The ProductCategoryDbo entity.</returns>
        ProductCategoryDbo Get(int id);

        /// <summary>
        /// Finds a ProductCategoryDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the product category.</param>
        /// <returns>The ProductCategoryDbo entity if found, otherwise null.</returns>
        ProductCategoryDbo Find(int id);

        /// <summary>
        /// Retrieves all ProductCategoryDbo entities.
        /// </summary>
        /// <returns>A list of ProductCategoryDbo entities.</returns>
        List<ProductCategoryDbo> GetAll();

        /// <summary>
        /// Updates an existing ProductCategoryDbo entity.
        /// </summary>
        /// <param name="advert">The ProductCategoryDbo entity to be updated.</param>
        void Update(ProductCategoryDbo advert);

        /// <summary>
        /// Deletes a ProductCategoryDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the product category to be deleted.</param>
        void Delete(int id);

        /// <summary>
        /// Adds a new ProductCategoryDbo entity.
        /// </summary>
        /// <param name="advert">The ProductCategoryDbo entity to be added.</param>
        void Add(ProductCategoryDbo advert);
    }
}
