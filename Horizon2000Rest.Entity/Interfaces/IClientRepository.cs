using Horizon2000Rest.Entity.Models;

namespace Horizon2000Rest.Entity.Interfaces
{
    public interface IClientRepository
    {
        /// <summary>
        /// Retrieves a ClientDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the client.</param>
        /// <returns>The ClientDbo entity.</returns>
        ClientDbo Get(int id);

        /// <summary>
        /// Finds a ClientDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the client.</param>
        /// <returns>The ClientDbo entity if found, otherwise null.</returns>
        ClientDbo Find(int id);

        /// <summary>
        /// Retrieves all ClientDbo entities.
        /// </summary>
        /// <returns>A list of ClientDbo entities.</returns>
        List<ClientDbo> GetAll();

        /// <summary>
        /// Updates an existing ClientDbo entity.
        /// </summary>
        /// <param name="advert">The ClientDbo entity to be updated.</param>
        void Update(ClientDbo advert);

        /// <summary>
        /// Deletes a ClientDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the client to be deleted.</param>
        void Delete(int id);

        /// <summary>
        /// Adds a new ClientDbo entity.
        /// </summary>
        /// <param name="advert">The ClientDbo entity to be added.</param>
        void Add(ClientDbo advert);
    }
}
