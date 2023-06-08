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
        /// <returns>The IActionResult containing a list of student DTOs.</returns>
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
        /// <returns>The IActionResult containing the student DTO if found, or NotFound if not found.</returns>
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

        /// <summary>
        /// Adds a new student.
        /// </summary>
        /// <param name="studentDto">The StudentDto containing the student data to add.</param>
        /// <returns>The IActionResult indicating the result of the operation.</returns>
        [HttpPost]
        public IActionResult AddStudent([FromBody] StudentDto studentDto)
        {
            var studentDbo = _studentWorker.AddStudent(studentDto);
            if (studentDbo == null)
            {
                return BadRequest();
            }

            var newStudentDto = _mapper.Map<GetStudentDto>(studentDbo);
            return CreatedAtAction(nameof(GetStudent), new { id = newStudentDto.StudentId }, newStudentDto);
        }

        /// <summary>
        /// Updates an existing student.
        /// </summary>
        /// <param name="id">The ID of the student to update.</param>
        /// <param name="studentDto">The StudentDto containing the student data to update.</param>
        /// <returns>The IActionResult indicating the result of the operation.</returns>
        [HttpPut("{id}")]
        public IActionResult UpdateStudent(string id, [FromBody] StudentDto studentDto)
        {
            if (id != studentDto.IdCard)
            {
                return BadRequest();
            }

            var studentDbo = _studentWorker.UpdateStudent(studentDto);
            if (studentDbo == null)
            {
                return NotFound();
            }

            var updatedStudentDto = _mapper.Map<GetStudentDto>(studentDbo);
            return Ok(updatedStudentDto);
        }

    }
}
