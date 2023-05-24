using Horizon2000Rest.Entity.Models;

namespace Horizon2000Rest.Entity.Interfaces
{
    public interface IUserRepository
    {
        /// <summary>
        /// Retrieves a UserDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the user.</param>
        /// <returns>The UserDbo entity.</returns>
        UserDbo Get(int id);

        /// <summary>
        /// Finds a UserDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the user.</param>
        /// <returns>The UserDbo entity if found, otherwise null.</returns>
        UserDbo Find(int id);

        /// <summary>
        /// Retrieves all UserDbo entities.
        /// </summary>
        /// <returns>A list of UserDbo entities.</returns>
        List<UserDbo> GetAll();

        /// <summary>
        /// Updates an existing UserDbo entity.
        /// </summary>
        /// <param name="advert">The UserDbo entity to be updated.</param>
        void Update(UserDbo advert);

        /// <summary>
        /// Deletes a UserDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the user to be deleted.</param>
        void Delete(int id);

        /// <summary>
        /// Adds a new UserDbo entity.
        /// </summary>
        /// <param name="advert">The UserDbo entity to be added.</param>
        void Add(UserDbo advert);
    }
}
