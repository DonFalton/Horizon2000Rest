using AutoMapper;
using Horizon2000Rest.Core.Models.ProductCategory;
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
        /// <returns>The list of product categories.</returns>
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
        /// <returns>The product category.</returns>
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
    }

}