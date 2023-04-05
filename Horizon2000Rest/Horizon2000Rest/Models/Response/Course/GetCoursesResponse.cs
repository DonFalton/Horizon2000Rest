using Horizon2000.Rest.Models.Course;
using System.Collections.Generic;

namespace Horizon2000.Rest.Models.Response.Course
{
	public class GetCoursesResponse : BaseResponseSO
	{
		/// <summary>
		/// List of Courses
		/// </summary>
		public List<GetCourseSo> Courses { get; set; }
	}
}