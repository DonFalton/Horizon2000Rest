using Horizon2000Rest.Core.Interfaces;
using Horizon2000Rest.Entity.Interfaces;
using Horizon2000Rest.Entity.Models;

namespace Horizon2000Rest.Core.Workers
{
    /// <summary>
    /// Implementation of the IStudentWorker interface for managing students operations.
    /// </summary>
    public class StudentWorker : IStudentWorker
    {
        private readonly IStudentRepository _studentRepository;

        public StudentWorker(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        /// <summary>
        /// Retrieves a student by ID.
        /// </summary>
        /// <param name="id">The ID of the student.</param>
        /// <returns>The student entity.</returns>
        public StudentDbo GetStudent(int id)
        {
            return _studentRepository.Get(id);
        }

        /// <summary>
        /// Retrieves all students.
        /// </summary>
        /// <returns>A list of student entities.</returns>
        public List<StudentDbo> GetAllStudents()
        {
            return _studentRepository.GetAll();
        }
    }
}