using Horizon2000.DataManagement.Models.ProductCategory;

namespace Horizon2000.Rest.Models.Response.ProductCategory
{
    /// <summary>
    /// Product Category Response Model
    /// </summary>
    public class ProductCategoryResponse: BaseResponseSO
    {
        /// <summary>
        /// Product Category Detail
        /// </summary>
        public ProductCategoryDto ProductCategory { get; set; }
    }
}