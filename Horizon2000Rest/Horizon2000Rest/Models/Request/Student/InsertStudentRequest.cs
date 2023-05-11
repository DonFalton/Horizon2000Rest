using Horizon2000.DataManagement.Models.Student;

namespace Horizon2000.Rest.Models.Request.Student
{
    /// <summary>
    /// Insert Student Request model
    /// </summary>
    public class InsertStudentRequest : BaseRequest
    {
        /// <summary>
        /// Student details
        /// </summary>
        public StudentDto Student { get; set; }
    }
}