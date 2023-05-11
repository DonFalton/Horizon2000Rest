using Horizon2000.DataManagement.Models.Course;

namespace Horizon2000.Rest.Models.Request.Course
{
    public class UpdateCourseRequest: BaseRequest
    {
        public UpdateCourseDto Course { get; set; }
    }
}