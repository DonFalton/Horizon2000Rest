using Horizon2000.Rest.Models.User;

namespace Horizon2000.Rest.Models.Request.User
{
	public class UserRequest : BaseRequest
	{
		public UserSo UserDetails { get; set; }
	}
}