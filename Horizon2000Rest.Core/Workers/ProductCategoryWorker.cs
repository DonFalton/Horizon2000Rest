using Horizon2000Rest.Entity.Data;
using Horizon2000Rest.Entity.Interfaces;
using Horizon2000Rest.Entity.Models;

namespace Horizon2000Rest.Core.Workers
{
    /// <summary>
    /// Worker class for managing product category operations.
    /// </summary>
    public class ProductCategoryWorker : IProductCategoryWorker
    {
        private readonly DataContext _dataContext;
        private readonly IProductCategoryRepository _productCategoryRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCategoryWorker"/> class.
        /// </summary>
        /// <param name="dataContext">The data context instance.</param>
        /// <param name="productCategoryRepository">The product category repository instance.</param>
        public ProductCategoryWorker(DataContext dataContext, IProductCategoryRepository productCategoryRepository)
        {
            _dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
            _productCategoryRepository = productCategoryRepository ?? throw new ArgumentNullException(nameof(productCategoryRepository));
        }

        /// <summary>
        /// Retrieves all product categories.
        /// </summary>
        /// <returns>A list of product categories.</returns>
        public List<ProductCategoryDbo> GetAllProductCategories()
        {
            return _productCategoryRepository.GetAll();
        }

        /// <summary>
        /// Retrieves a product category by ID.
        /// </summary>
        /// <param name="id">The ID of the product category.</param>
        /// <returns>The product category.</returns>
        public ProductCategoryDbo GetProductCategory(int id)
        {
            return _productCategoryRepository.Get(id);
        }
    }
}