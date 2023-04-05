using Horizon2000.Rest.Models.User;

namespace Horizon2000.Rest.Models.Response.User
{
	public class UserResponse : BaseResponseSO
	{
		public UserSo UserDetails { get; set; }

	}
}