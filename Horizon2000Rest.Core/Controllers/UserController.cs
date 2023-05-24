using AutoMapper;
using Horizon2000Rest.Core.Models.User;
using Horizon2000Rest.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Horizon2000Rest.Controllers
{
    /// <summary>
    /// Controller for managing user.
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
        /// <returns>A list of user DTOs.</returns>
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
        /// <returns>The user DTO.</returns>
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
    }

}