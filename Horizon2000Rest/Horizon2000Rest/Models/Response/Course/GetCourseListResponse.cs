using Horizon2000.DataManagement.Models.Course;
using System.Collections.Generic;

namespace Horizon2000.Rest.Models.Response.Course
{
    /// <summary>
    /// Get Course List Response Model
    /// </summary>
    public class GetCourseListResponse : BaseResponseSO
    {
        /// <summary>
        /// List of courses grouped by parent course
        /// </summary>
        public List<GetParentCourseListDto> CourseList { get; set; }
    }
}