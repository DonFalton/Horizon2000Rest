using AutoMapper;
using Horizon2000Rest.Core.Interfaces;
using Horizon2000Rest.Core.Models.Student;
using Horizon2000Rest.Entity.Interfaces;
using Horizon2000Rest.Entity.Models;

namespace Horizon2000Rest.Core.Workers
{
    /// <summary>
    /// Implementation of the IStudentWorker interface for managing student operations.
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

        /// <inheritdoc/>
        public StudentDbo GetStudent(int id)
        {
            return _studentRepository.Get(id);
        }

        /// <inheritdoc/>
        public List<StudentDbo> GetAllStudents()
        {
            return _studentRepository.GetAll();
        }

        /// <inheritdoc/>
        public StudentDbo AddStudent(StudentDto studentDto)
        {
            // Map the DTO to a DBO.
            var studentDbo = _mapper.Map<StudentDbo>(studentDto);

            // Add the student to the repository and save changes.
            _studentRepository.Add(studentDbo);
            _studentRepository.Save();

            return studentDbo;
        }

        /// <inheritdoc/>
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
