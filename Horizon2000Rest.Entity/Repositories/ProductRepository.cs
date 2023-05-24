using Horizon2000Rest.Entity.Data;
using Horizon2000Rest.Entity.Interfaces;
using Horizon2000Rest.Entity.Models;

namespace Horizon2000REST.Entity.Repositories
{
    /// <inheritdoc/>
    /// <seealso cref="IProductRepository"/>
    /// <summary>
    /// Repository class for managing products.
    /// </summary>
    public class ProductRepository : IProductRepository
    {
        /// <summary>
        /// Database context.
        /// </summary>
        private readonly DataContext _dataContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductRepository"/> class.
        /// </summary>
        /// <param name="horizonContext">The database context.</param>
        public ProductRepository(DataContext horizonContext)
        {
            _dataContext = horizonContext;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Retrieves a ProductDbo object by its ID.
        /// </summary>
        /// <param name="id">The ID of the product to retrieve.</param>
        /// <returns>The retrieved ProductDbo object.</returns>
        public ProductDbo Get(int id)
        {
            return _dataContext.Products.FirstOrDefault(x => x.ID == id) ??
                throw new ArgumentNullException("Product not found");
        }

        /// <inheritdoc/>
        /// <summary>
        /// Finds a ProductDbo object by its ID.
        /// </summary>
        /// <param name="id">The ID of the product to find.</param>
        /// <returns>The found ProductDbo object, or null if not found.</returns>
        public ProductDbo Find(int id) =>
            _dataContext.Products.FirstOrDefault(x => x.ID == id);

        /// <inheritdoc/>
        /// <summary>
        /// Retrieves all active ProductDbo objects.
        /// </summary>
        /// <returns>A list of active ProductDbo objects.</returns>
        public List<ProductDbo> GetAll() =>
            _dataContext.Products
                .Where(x => x.IsActive)
                .ToList();

        /// <inheritdoc/>
        /// <summary>
        /// Updates a ProductDbo object.
        /// </summary>
        /// <param name="product">The ProductDbo object to update.</param>
        public void Update(ProductDbo product)
        {
            _dataContext.Update(product);
        }

        /// <inheritdoc/>
        /// <summary>
        /// Deletes a ProductDbo object by setting IsActive to false.
        /// </summary>
        /// <param name="id">The ID of the product to delete.</param>
        public void Delete(int id)
        {
            var product = Get(id);
            product.IsActive = false;

            Update(product);
        }

        /// <inheritdoc/>
        /// <summary>
        /// Adds a new ProductDbo object.
        /// </summary>
        /// <param name="product">The ProductDbo object to add.</param>
        public void Add(ProductDbo product)
        {
            _dataContext.Products.Add(product);
        }
    }
}
