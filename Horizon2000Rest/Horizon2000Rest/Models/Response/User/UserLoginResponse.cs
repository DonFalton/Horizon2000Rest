using Horizon2000.DataManagement.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Horizon2000.Rest.Models.Response.User
{
	public class UserLoginResponse : UserResponse
	{
		public List<RoleEnum> UserRoles { get; set; }

		public string Session { get; set; }
	}
}