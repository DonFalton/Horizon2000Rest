using AutoMapper;
using Horizon2000Rest.Core.Models.User;
using Horizon2000Rest.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Horizon2000Rest.Entity.Models;

namespace Horizon2000Rest.Controllers
{
    /// <summary>
    /// Controller for managing users.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserWorker _userWorker;

        public UserController(IMapper mapper, IUserWorker userWorker)
        {
            _mapper = mapper;
            _userWorker = userWorker;
        }

        /// <summary>
        /// Retrieves all users.
        /// </summary>
        /// <returns>The IActionResult containing a list of user DTOs.</returns>
        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var users = _userWorker.GetAllUsers();
            var userDtos = _mapper.Map<List<UserDto>>(users);
            return Ok(userDtos);
        }

        /// <summary>
        /// Retrieves a user by ID.
        /// </summary>
        /// <param name="id">The ID of the user.</param>
        /// <returns>The IActionResult containing the user DTO if found, or NotFound if not found.</returns>
        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var userDbo = _userWorker.GetUser(id);
            if (userDbo == null)
            {
                return NotFound();
            }

            var userDto = _mapper.Map<UserDto>(userDbo);
            return Ok(userDto);
        }

        /// <summary>
        /// Creates a new user.
        /// </summary>
        /// <param name="userDto">The UserDto containing the user data to create.</param>
        /// <returns>The IActionResult indicating the result of the operation.</returns>
        [HttpPost]
        public IActionResult CreateUser(UserDto userDto)
        {
            var userDbo = _mapper.Map<UserDbo>(userDto);

            // Add the user to the repository and save changes.
            _userWorker.AddUser(userDbo);

            var createdUserDto = _mapper.Map<UserDto>(userDbo);
            return CreatedAtAction(nameof(GetUser), new { id = createdUserDto.ID }, createdUserDto);
        }

        /// <summary>
        /// Updates an existing user.
        /// </summary>
        /// <param name="id">The ID of the user to update.</param>
        /// <param name="userDto">The UserDto containing the user data to update.</param>
        /// <returns>The IActionResult indicating the result of the operation.</returns>
        [HttpPut("{id}")]
        public IActionResult UpdateUser(int id, UserDto userDto)
        {
            var existingUserDbo = _userWorker.GetUser(id);
            if (existingUserDbo == null)
            {
                return NotFound();
            }

            // Update the properties of the existing user.
            _mapper.Map(userDto, existingUserDbo);
            _userWorker.UpdateUser(existingUserDbo);

            var updatedUserDto = _mapper.Map<UserDto>(existingUserDbo);
            return Ok(updatedUserDto);
        }
    }

}
