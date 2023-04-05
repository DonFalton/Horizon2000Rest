using Horizon2000.DataManagement.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Horizon2000.Rest.Models.Response.Product
{
    public class ProductsResponse : BaseResponseSO
    {

        public List<ProductDto> Products { get; set; }

        public int Next { get; set; }
    }
}