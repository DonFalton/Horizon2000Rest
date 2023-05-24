using Horizon2000Rest.Core.Interfaces;
using Horizon2000Rest.Entity.Data;
using Horizon2000Rest.Entity.Interfaces;
using Horizon2000Rest.Entity.Models;

namespace Horizon2000Rest.Core.Workers
{
    /// <summary>
    /// Implementation of the IProductWorker interface for managing product operations.
    /// </summary>
    public class ProductWorker : IProductWorker
    {
        private readonly DataContext _dataContext;
        private readonly IProductRepository _productRepository;

        public ProductWorker(DataContext dataContext, IProductRepository productRepository)
        {
            _dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
        }

        /// <inheritdoc/>
        public ProductDbo GetProduct(int id)
        {
            return _productRepository.Get(id);
        }
    }
}