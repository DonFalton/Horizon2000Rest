using AutoMapper;
using Horizon2000Rest.Core.Interfaces;
using Horizon2000Rest.Core.Models.Student;
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
        private readonly IMapper _mapper;

        public StudentWorker(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
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

        public StudentDbo AddStudent(StudentDto studentDto)
        {
            // Map the DTO to a DBO.
            var studentDbo = _mapper.Map<StudentDbo>(studentDto);

            // Add the student to the repository and save changes.
            _studentRepository.Add(studentDbo);
            _studentRepository.Save();

            return studentDbo;
        }

        public StudentDbo UpdateStudent(StudentDto studentDto)
        {
            // Get the existing student from the repository.
            var existingStudent = _studentRepository.Get(studentDto.ID);
            if (existingStudent == null)
            {
                return null;
            }

            // Map the DTO to the existing DBO.
            _mapper.Map(studentDto, existingStudent);

            // Update the student in the repository and save changes.
            _studentRepository.Update(existingStudent);
            _studentRepository.Save();

            return existingStudent;
        }
    }
}