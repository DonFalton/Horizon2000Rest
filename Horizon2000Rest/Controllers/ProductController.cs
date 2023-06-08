using AutoMapper;
using Horizon2000Rest.Core.Interfaces;
using Horizon2000Rest.Core.Models.Product;
using Microsoft.AspNetCore.Mvc;

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
        /// Initializes a new instance of the ProductController class.
        /// </summary>
        /// <param name="mapper">The IMapper instance for object mapping.</param>
        /// <param name="productWorker">The IProductWorker instance for product operations.</param>
        public ProductController(IMapper mapper, IProductWorker productWorker)
        {
            _mapper = mapper;
            _productWorker = productWorker;
        }

        /// <summary>
        /// Retrieves a product by ID.
        /// </summary>
        /// <param name="id">The ID of the product.</param>
        /// <returns>The IActionResult containing the product information if found, or BadRequest with an appropriate message if not found.</returns>
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var productDto = _productWorker.GetProduct(id);
            return productDto is { }
                ? Ok(productDto)
                : BadRequest("Product not found");
        }

        /// <summary>
        /// Adds a new product.
        /// </summary>
        /// <param name="newProductDto">The AddProductDto containing the product data to add.</param>
        /// <returns>The IActionResult indicating the result of the operation.</returns>
        [HttpPost]
        public IActionResult AddProduct([FromBody] AddProductDto newProductDto)
        {
            var addedProduct = _productWorker.AddProduct(newProductDto);
            var resultProductDto = _mapper.Map<ProductDto>(addedProduct);
            return CreatedAtAction(nameof(GetProduct), new { id = resultProductDto.Id }, resultProductDto);
        }

        /// <summary>
        /// Updates an existing product.
        /// </summary>
        /// <param name="id">The ID of the product to update.</param>
        /// <param name="updateProductDto">The UpdateProductDto containing the product data to update.</param>
        /// <returns>The IActionResult indicating the result of the operation.</returns>
        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] UpdateProductDto updateProductDto)
        {
            if (id != updateProductDto.Id)
            {
                return BadRequest();
            }

            var updatedProduct = _productWorker.UpdateProduct(updateProductDto);
            var resultProductDto = _mapper.Map<ProductDto>(updatedProduct);
            return Ok(resultProductDto);
        }

    }
}
