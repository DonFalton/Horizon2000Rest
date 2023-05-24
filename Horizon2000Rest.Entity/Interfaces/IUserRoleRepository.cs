using Horizon2000Rest.Entity.Models;

namespace Horizon2000Rest.Entity.Interfaces
{
    public interface IUserRoleRepository
    {
        /// <summary>
        /// Retrieves a UserRoleDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the user role.</param>
        /// <returns>The UserRoleDbo entity.</returns>
        UserRoleDbo Get(int id);

        /// <summary>
        /// Finds a UserRoleDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the user role.</param>
        /// <returns>The UserRoleDbo entity if found, otherwise null.</returns>
        UserRoleDbo Find(int id);

        /// <summary>
        /// Retrieves all UserRoleDbo entities.
        /// </summary>
        /// <returns>A list of UserRoleDbo entities.</returns>
        List<UserRoleDbo> GetAll();

        /// <summary>
        /// Updates an existing UserRoleDbo entity.
        /// </summary>
        /// <param name="advert">The UserRoleDbo entity to be updated.</param>
        void Update(UserRoleDbo advert);

        /// <summary>
        /// Deletes a UserRoleDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the user role to be deleted.</param>
        void Delete(int id);

        /// <summary>
        /// Adds a new UserRoleDbo entity.
        /// </summary>
        /// <param name="advert">The UserRoleDbo entity to be added.</param>
        void Add(UserRoleDbo advert);
    }
}
