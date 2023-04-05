using Horizon2000.Rest.Models.ParentCourse;
using System.Collections.Generic;

namespace Horizon2000.Rest.Models.Response.ParentCourse
{
	/// <summary>
	/// Get Parent Courses Response model. Used to get list of parent courses which are active 
	/// </summary>
	public class GetParentCoursesResponse : BaseResponseSO
	{
		public List<GetParentCoursesSo> ParentCourses { get; set; }
	}
}