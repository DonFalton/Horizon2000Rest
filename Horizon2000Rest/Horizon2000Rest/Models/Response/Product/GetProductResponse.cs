using Horizon2000.DataManagement.Models.Product;

namespace Horizon2000.Rest.Models.Response.Product
{
    public class GetProductResponse: BaseResponseSO
    {
        public ProductDto Product { get; set; }
    }
}