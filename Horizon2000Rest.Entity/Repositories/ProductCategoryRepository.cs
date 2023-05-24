using Horizon2000Rest.Entity.Data;
using Horizon2000Rest.Entity.Interfaces;
using Horizon2000Rest.Entity.Models;

namespace Horizon2000REST.Entity.Repositories
{
    /// <inheritdoc/>
    /// <seealso cref="IProductCategoryRepository"/>
    /// <summary>
    /// Repository class for managing product categories.
    /// </summary>
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        /// <summary>
        /// Database context.
        /// </summary>
        private readonly DataContext _dataContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCategoryRepository"/> class.
        /// </summary>
        /// <param name="horizonContext">The database context.</param>
        public ProductCategoryRepository(DataContext horizonContext)
        {
            _dataContext = horizonContext;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Retrieves a ProductCategoryDbo object by its ID.
        /// </summary>
        /// <param name="id">The ID of the product category to retrieve.</param>
        /// <returns>The retrieved ProductCategoryDbo object.</returns>
        public ProductCategoryDbo Get(int id)
        {
            return _dataContext.ProductCategories.FirstOrDefault(x => x.ID == id) ??
                throw new ArgumentNullException("ProductCategory not found");
        }

        /// <inheritdoc/>
        /// <summary>
        /// Finds a ProductCategoryDbo object by its ID.
        /// </summary>
        /// <param name="id">The ID of the product category to find.</param>
        /// <returns>The found ProductCategoryDbo object, or null if not found.</returns>
        public ProductCategoryDbo Find(int id) =>
            _dataContext.ProductCategories.FirstOrDefault(x => x.ID == id);

        /// <inheritdoc/>
        /// <summary>
        /// Retrieves all active ProductCategoryDbo objects.
        /// </summary>
        /// <returns>A list of active ProductCategoryDbo objects.</returns>
        public List<ProductCategoryDbo> GetAll() =>
            _dataContext.ProductCategories
                .Where(x => x.IsActive)
                .ToList();

        /// <inheritdoc/>
        /// <summary>
        /// Updates a ProductCategoryDbo object.
        /// </summary>
        /// <param name="productCategory">The ProductCategoryDbo object to update.</param>
        public void Update(ProductCategoryDbo productCategory)
        {
            _dataContext.Update(productCategory);
        }

        /// <inheritdoc/>
        /// <summary>
        /// Deletes a ProductCategoryDbo object by setting IsActive to false.
        /// </summary>
        /// <param name="id">The ID of the product category to delete.</param>
        public void Delete(int id)
        {
            var productCategory = Get(id);
            productCategory.IsActive = false;

            Update(productCategory);
        }

        /// <inheritdoc/>
        /// <summary>
        /// Adds a new ProductCategoryDbo object.
        /// </summary>
        /// <param name="productCategory">The ProductCategoryDbo object to add.</param>
        public void Add(ProductCategoryDbo productCategory)
        {
            _dataContext.ProductCategories.Add(productCategory);
        }
    }
}
