using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Horizon2000.Rest.Models.Request.User
{
	public class UserSessionLoginRequest: BaseRequest
	{

		public string Session { get; set; }
	}
}