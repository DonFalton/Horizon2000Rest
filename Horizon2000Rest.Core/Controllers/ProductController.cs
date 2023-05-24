using AutoMapper;
using Horizon2000Rest.Core.Interfaces;
using Horizon2000Rest.Core.Models.Product;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Horizon2000Rest.Controllers
{
    /// <summary>
    /// Controller for managing product operations.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IProductWorker _productWorker;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductController"/> class.
        /// </summary>
        /// <param name="mapper">The mapper instance.</param>
        /// <param name="productWorker">The product worker instance.</param>
        public ProductController(IMapper mapper, IProductWorker productWorker)
        {
            _mapper = mapper;
            _productWorker = productWorker;
        }

        /// <summary>
        /// Retrieves a product by ID.
        /// </summary>
        /// <param name="id">The ID of the product.</param>
        /// <returns>The product information.</returns>
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var productDbo = _productWorker.GetProduct(id);
            if (productDbo == null)
            {
                return NotFound();
            }

            var productDto = _mapper.Map<ProductDto>(productDbo);
            return Ok(productDto);
        }
    }
}
