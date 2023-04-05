namespace Horizon2000.Rest.Models
{
	/// <summary>
	/// Base Response
	/// </summary>
	public class BaseResponseSO
	{
		/// <summary>
		/// Is Response Successful
		/// </summary>
		public bool IsSuccessful { get; set; }

		/// <summary>
		/// Error Code (if any)
		/// </summary>
		public string ErrorCode { get; set; }

		/// <summary>
		/// Error message (if any)
		/// </summary>
		public string ErrorMessage { get; set; }
	}
}