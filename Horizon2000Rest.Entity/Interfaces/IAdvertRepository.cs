using Horizon2000Rest.Entity.Models;

namespace Horizon2000Rest.Entity.Interfaces
{
    /// <summary>
    /// Provides methods for accessing the 'Advert' data.
    /// </summary>
    public interface IAdvertRepository
    {
        /// <summary>
        /// Retrieves an AdvertDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the advert.</param>
        /// <returns>The AdvertDbo entity.</returns>
        AdvertDbo Get(int id);

        /// <summary>
        /// Finds an AdvertDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the advert.</param>
        /// <returns>The AdvertDbo entity if found, otherwise null.</returns>
        AdvertDbo Find(int id);

        /// <summary>
        /// Retrieves all AdvertDbo entities.
        /// </summary>
        /// <returns>A list of AdvertDbo entities.</returns>
        List<AdvertDbo> GetAll();

        /// <summary>
        /// Updates an existing AdvertDbo entity.
        /// </summary>
        /// <param name="advert">The AdvertDbo entity to be updated.</param>
        void Update(AdvertDbo advert);

        /// <summary>
        /// Deletes an AdvertDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the advert to be deleted.</param>
        void Delete(int id);

        /// <summary>
        /// Adds a new AdvertDbo entity.
        /// </summary>
        /// <param name="advert">The AdvertDbo entity to be added.</param>
        void Add(AdvertDbo advert);
    }
}
