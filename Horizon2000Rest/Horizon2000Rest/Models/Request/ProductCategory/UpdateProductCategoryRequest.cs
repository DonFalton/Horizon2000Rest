using Horizon2000.DataManagement.Models.ProductCategory;

namespace Horizon2000.Rest.Models.Request.ProductCategory
{
    /// <summary>
    /// Update Product Category Request
    /// </summary>
    public class UpdateProductCategoryRequest : BaseRequest
    {
        public UpdateProductCategoryDto Details { get; set; }
    }
}