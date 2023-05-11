using Horizon2000.DataManagement.Models.Advert;
using System.Collections.Generic;

namespace Horizon2000.Rest.Models.Response.Advert
{
    public class GetAdvertsResponse : BaseResponseSO
    {
        public List<GetAdvertDto> Adverts { get; set; }
    }
}