using Horizon2000.DataManagement.Models.Product;

namespace Horizon2000.Rest.Models.Request.Product
{
    public class UpdateProductRequest: BaseRequest
    {
        public UpdateProductDto Product { get; set; }
    }
}