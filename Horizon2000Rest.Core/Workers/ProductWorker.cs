using AutoMapper;
using Horizon2000Rest.Core.Interfaces;
using Horizon2000Rest.Core.Models.Product;
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
        private readonly IMapper _mapper;

        public ProductWorker(DataContext dataContext, IProductRepository productRepository, IMapper mapper)
        {
            _dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <inheritdoc/>
        public ProductDbo GetProduct(int id)
        {
            return _productRepository.Get(id);
        }

        public ProductDbo AddProduct(AddProductDto productDto)
        {
            var product = _mapper.Map<ProductDbo>(productDto);
            _productRepository.Add(product);
            _dataContext.SaveChanges();
            return product;
        }

        public ProductDbo UpdateProduct(UpdateProductDto productDto)
        {
            var product = _productRepository.Get(productDto.Id);
            if (product == null)
            {
                throw new Exception($"Product with id {productDto.Id} not found");
            }

            product = _mapper.Map(productDto, product);
            _productRepository.Update(product);
            _dataContext.SaveChanges();
            return product;
        }
    }
}