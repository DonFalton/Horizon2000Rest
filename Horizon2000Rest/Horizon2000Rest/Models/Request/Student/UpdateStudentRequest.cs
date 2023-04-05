using Horizon2000.DataManagement.Models.Student;

namespace Horizon2000.Rest.Models.Request.Student
{
    public class UpdateStudentRequest : BaseRequest
    {
        public GetStudentDto Student { get; set; }
    }
}