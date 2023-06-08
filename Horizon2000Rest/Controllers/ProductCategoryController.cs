using AutoMapper;
using Horizon2000Rest.Core.Models.ProductCategory;
using Horizon2000Rest.Entity.Models;
using Microsoft.AspNetCore.Mvc;

namespace Horizon2000Rest.Controllers
{
    /// <summary>
    /// Controller for managing product categories.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IProductCategoryWorker _productCategoryWorker;

        public ProductCategoryController(IMapper mapper, IProductCategoryWorker productCategoryWorker)
        {
            _mapper = mapper;
            _productCategoryWorker = productCategoryWorker;
        }

        /// <summary>
        /// Retrieves all product categories.
        /// </summary>
        /// <returns>The IActionResult containing the list of product categories.</returns>
        [HttpGet]
        public IActionResult GetAllProductCategories()
        {
            var productCategories = _productCategoryWorker.GetAllProductCategories();
            var productCategoryDtos = _mapper.Map<List<ProductCategoryDto>>(productCategories);
            return Ok(productCategoryDtos);
        }

        /// <summary>
        /// Retrieves a product category by ID.
        /// </summary>
        /// <param name="id">The ID of the product category.</param>
        /// <returns>The IActionResult containing the product category if found, or NotFound if not found.</returns>
        [HttpGet("{id}")]
        public IActionResult GetProductCategory(int id)
        {
            var productCategoryDbo = _productCategoryWorker.GetProductCategory(id);
            if (productCategoryDbo == null)
            {
                return NotFound();
            }

            var productCategoryDto = _mapper.Map<ProductCategoryDto>(productCategoryDbo);
            return Ok(productCategoryDto);
        }

        /// <summary>
        /// Adds a new product category.
        /// </summary>
        /// <param name="productCategoryDto">The UpdateProductCategoryDto containing the product category data to add.</param>
        /// <returns>The IActionResult indicating the result of the operation.</returns>
        [HttpPost]
        public IActionResult AddProductCategory([FromBody] UpdateProductCategoryDto productCategoryDto)
        {
            var productCategoryDbo = _mapper.Map<ProductCategoryDbo>(productCategoryDto);
            _productCategoryWorker.AddProductCategory(productCategoryDbo);
            return Ok();
        }

        /// <summary>
        /// Updates an existing product category.
        /// </summary>
        /// <param name="id">The ID of the product category to update.</param>
        /// <param name="productCategoryDto">The UpdateProductCategoryDto containing the product category data to update.</param>
        /// <returns>The IActionResult indicating the result of the operation.</returns>
        [HttpPut("{id}")]
        public IActionResult UpdateProductCategory(int id, [FromBody] UpdateProductCategoryDto productCategoryDto)
        {
            var existingProductCategory = _productCategoryWorker.GetProductCategory(id);
            if (existingProductCategory == null)
            {
                return NotFound();
            }

            var productCategoryDbo = _mapper.Map<ProductCategoryDbo>(productCategoryDto);
            productCategoryDbo.ID = id; // Ensure the ID is set correctly

            _productCategoryWorker.UpdateProductCategory(productCategoryDbo);
            return Ok();
        }
    }
}
