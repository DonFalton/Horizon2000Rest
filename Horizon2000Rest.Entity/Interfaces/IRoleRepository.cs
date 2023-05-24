using Horizon2000Rest.Entity.Models;

namespace Horizon2000Rest.Entity.Interfaces
{
    public interface IRoleRepository
    {
        /// <summary>
        /// Retrieves a RoleDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the role.</param>
        /// <returns>The RoleDbo entity.</returns>
        RoleDbo Get(int id);

        /// <summary>
        /// Finds a RoleDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the role.</param>
        /// <returns>The RoleDbo entity if found, otherwise null.</returns>
        RoleDbo Find(int id);

        /// <summary>
        /// Retrieves all RoleDbo entities.
        /// </summary>
        /// <returns>A list of RoleDbo entities.</returns>
        List<RoleDbo> GetAll();

        /// <summary>
        /// Updates an existing RoleDbo entity.
        /// </summary>
        /// <param name="advert">The RoleDbo entity to be updated.</param>
        void Update(RoleDbo advert);

        /// <summary>
        /// Deletes a RoleDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the role to be deleted.</param>
        void Delete(int id);

        /// <summary>
        /// Adds a new RoleDbo entity.
        /// </summary>
        /// <param name="advert">The RoleDbo entity to be added.</param>
        void Add(RoleDbo advert);
    }
}
