using Horizon2000.DataManagement.Models.Course;

namespace Horizon2000.Rest.Models.Request.Course
{
    public class CreateCourseRequest:BaseRequest
    {
        public CreateCourseDto Course { get; set; }
    }
}