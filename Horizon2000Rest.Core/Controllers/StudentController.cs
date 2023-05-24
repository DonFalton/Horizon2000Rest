using AutoMapper;
using Horizon2000Rest.Core.Interfaces;
using Horizon2000Rest.Core.Models.Student;
using Microsoft.AspNetCore.Mvc;

namespace Horizon2000Rest.Controllers
{
    /// <summary>
    /// Controller for managing students.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IStudentWorker _studentWorker;

        public StudentController(IMapper mapper, IStudentWorker studentWorker)
        {
            _mapper = mapper;
            _studentWorker = studentWorker;
        }

        /// <summary>
        /// Retrieves all students.
        /// </summary>
        /// <returns>A list of student DTOs.</returns>
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            var students = _studentWorker.GetAllStudents();
            var studentDtos = _mapper.Map<List<GetStudentDto>>(students);
            return Ok(studentDtos);
        }

        /// <summary>
        /// Retrieves a student by ID.
        /// </summary>
        /// <param name="id">The ID of the student.</param>
        /// <returns>The student DTO.</returns>
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            var studentDbo = _studentWorker.GetStudent(id);
            if (studentDbo == null)
            {
                return NotFound();
            }

            var studentDto = _mapper.Map<GetStudentDto>(studentDbo);
            return Ok(studentDto);
        }
    }
}
