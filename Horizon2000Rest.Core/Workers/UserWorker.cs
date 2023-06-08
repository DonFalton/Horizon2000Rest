using Horizon2000Rest.Entity.Interfaces;
using Horizon2000Rest.Entity.Models;
using Horizon2000Rest.Core.Interfaces;
using Horizon2000Rest.Core.Models.User;
using Horizon2000Rest.Core.Authentication;

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

        /// <inheritdoc/>
        public UserDbo GetUser(int id)
        {
            return _userRepository.Get(id);
        }

        /// <inheritdoc/>
        public List<UserDbo> GetAllUsers()
        {
            return _userRepository.GetAll();
        }

        /// <inheritdoc/>
        public void AddUser(UserDbo userDbo)
        {
            _userRepository.Add(userDbo);
            _userRepository.Save();
        }

        /// <inheritdoc/>
        public void UpdateUser(UserDbo userDbo)
        {
            _userRepository.Update(userDbo);
            _userRepository.Save();
        }

        #region JWT

        /// <inheritdoc/>
        public UserLoginDto UserLogin(string username, string password)
        {
            string token = JwtHelper.GenerateToken(username);

            return new UserLoginDto
            {
                Status = "Success",
                Message = token
            };
        }

        /// <inheritdoc/>
        public UserLoginDto UserValidation(string username, string token)
        {
            bool isValid = JwtHelper.ValidateToken(token) == username;

            if (isValid)
            {
                return new UserLoginDto
                {
                    Status = "Success",
                    Message = "OK"
                };
            }
            else
            {
                return new UserLoginDto
                {
                    Status = "Invalid",
                    Message = "Invalid Token"
                };
            }
        }

        #endregion
    }
}
