using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Horizon2000.Rest.Models.Request.Product
{
    public class AddProductRequest : BaseRequest
    {

        public string Name { get; set; }

        public int CategoryId { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }
    }
}