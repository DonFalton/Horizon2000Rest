using Horizon2000Rest.Entity.Models;
using System.Collections.Generic;

namespace Horizon2000Rest.Core.Interfaces
{
    /// <summary>
    /// Interface for managing user operations.
    /// </summary>
    public interface IUserWorker
    {
        /// <summary>
        /// Retrieves a user by ID.
        /// </summary>
        /// <param name="id">The ID of the user.</param>
        /// <returns>The user entity.</returns>
        UserDbo GetUser(int id);

        /// <summary>
        /// Retrieves all users.
        /// </summary>
        /// <returns>A list of user entities.</returns>
        List<UserDbo> GetAllUsers();
    }
}