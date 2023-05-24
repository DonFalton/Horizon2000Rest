using Horizon2000Rest.Entity.Models;

namespace Horizon2000Rest.Entity.Interfaces
{
    public interface IUserSessionRepository
    {
        /// <summary>
        /// Retrieves a UserSessionDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the user session.</param>
        /// <returns>The UserSessionDbo entity.</returns>
        UserSessionDbo Get(int id);

        /// <summary>
        /// Finds a UserSessionDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the user session.</param>
        /// <returns>The UserSessionDbo entity if found, otherwise null.</returns>
        UserSessionDbo Find(int id);

        /// <summary>
        /// Retrieves all UserSessionDbo entities.
        /// </summary>
        /// <returns>A list of UserSessionDbo entities.</returns>
        List<UserSessionDbo> GetAll();

        /// <summary>
        /// Updates an existing UserSessionDbo entity.
        /// </summary>
        /// <param name="advert">The UserSessionDbo entity to be updated.</param>
        void Update(UserSessionDbo advert);

        /// <summary>
        /// Deletes a UserSessionDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the user session to be deleted.</param>
        void Delete(int id);

        /// <summary>
        /// Adds a new UserSessionDbo entity.
        /// </summary>
        /// <param name="advert">The UserSessionDbo entity to be added.</param>
        void Add(UserSessionDbo advert);
    }
}
