using Horizon2000.DataManagement.Models.Student;
using System.Collections.Generic;

namespace Horizon2000.Rest.Models.Response.Student
{
    /// <summary>
    /// Student Response model
    /// </summary>
    public class StudentResponse : BaseResponseSO
    {
        /// <summary>
        /// List of Student Details
        /// </summary>
        public List<GetStudentDto> Students { get; set; }
    }
}