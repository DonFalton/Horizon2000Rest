using Horizon2000Rest.Entity.Interfaces;
using Horizon2000Rest.Entity.Models;
using Horizon2000Rest.Core.Interfaces;

namespace Horizon2000Rest.Core.Workers
{
    /// <summary>
    /// Implementation of the IUserWorker interface for managing user operations.
    /// </summary>
    public class UserWorker : IUserWorker
    {
        private readonly IUserRepository _userRepository;

        public UserWorker(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        /// <summary>
        /// Retrieves a user by ID.
        /// </summary>
        /// <param name="id">The ID of the user.</param>
        /// <returns>The user entity.</returns>
        public UserDbo GetUser(int id)
        {
            return _userRepository.Get(id);
        }

        /// <summary>
        /// Retrieves all users.
        /// </summary>
        /// <returns>A list of user entities.</returns>
        public List<UserDbo> GetAllUsers()
        {
            return _userRepository.GetAll();
        }
    }
}