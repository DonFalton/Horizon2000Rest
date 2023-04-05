using Horizon2000.Rest.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Horizon2000.Rest.Models.Request.User
{
	public class UserLoginRequest : BaseRequest
	{
		public UserLoginSo UserLogin { get; set; }
	}
}