using Horizon2000.DataManagement.Models.ProductCategory;
using System.Collections.Generic;

namespace Horizon2000.Rest.Models.Response.ProductCategory
{
    /// <summary>
    /// Product Categories Response model
    /// </summary>
    public class ProductCategoriesResponse: BaseResponseSO
    {
        /// <summary>
        /// List of Product Categories
        /// </summary>
        public List<ProductCategoryDto> ProductCategories { get; set; }
    }
}