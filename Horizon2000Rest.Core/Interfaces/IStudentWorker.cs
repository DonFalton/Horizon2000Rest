using Horizon2000Rest.Core.Models.Student;
using Horizon2000Rest.Entity.Models;
using System.Collections.Generic;

namespace Horizon2000Rest.Core.Interfaces
{
    /// <summary>
    /// Interface for managing product operations.
    /// </summary>
    public interface IStudentWorker
    {
        /// <summary>
        /// Retrieves a student by ID.
        /// </summary>
        /// <param name="id">The ID of the student.</param>
        /// <returns>The student entity.</returns>
        StudentDbo GetStudent(int id);

        /// <summary>
        /// Retrieves all students.
        /// </summary>
        /// <returns>A list of student entities.</returns>
        List<StudentDbo> GetAllStudents();

        /// <summary>
        /// Adds a new student.
        /// </summary>
        /// <param name="studentDto">The student DTO.</param>
        /// <returns>The added student entity.</returns>
        StudentDbo AddStudent(StudentDto studentDto);

        /// <summary>
        /// Updates an existing student.
        /// </summary>
        /// <param name="studentDto">The student DTO.</param>
        /// <returns>The updated student entity.</returns>
        StudentDbo UpdateStudent(StudentDto studentDto);
    }
}
