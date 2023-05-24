namespace Horizon2000Rest.Core.Models.Student
{
    /// <summary>
    /// Data transfer object for retrieving a student.
    /// Inherits from StudentDto.
    /// </summary>
    public class GetStudentDto : StudentDto
    {
        /// <summary>
        /// Gets or sets the ID of the student.
        /// </summary>
        public int ID { get; set; }
    }
}
