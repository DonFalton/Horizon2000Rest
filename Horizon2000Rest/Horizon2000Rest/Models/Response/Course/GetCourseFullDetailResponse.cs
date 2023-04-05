using Horizon2000.Rest.Models.Course;

namespace Horizon2000.Rest.Models.Response.Course
{
	public class GetCourseFullDetailResponse:BaseResponseSO
	{
		public GetCourseFullDetailSo Course { get; set; }
	}
}