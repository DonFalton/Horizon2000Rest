using Horizon2000.DataManagement.Models.Advert;

namespace Horizon2000.Rest.Models.Request.Advert
{
    public class AddAdvertRequest : BaseRequest
    {
        public AddAdvertDto Advert { get; set; }
    }
}