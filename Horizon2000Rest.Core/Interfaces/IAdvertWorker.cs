using Horizon2000Rest.Core.Models.Advert;

namespace Horizon2000Rest.Core.Interfaces
{
    /// <summary>
    /// Interface for managing advert operations.
    /// </summary>
    public interface IAdvertWorker
    {
        /// <summary>
        /// Retrieves an advert by ID.
        /// </summary>
        /// <param name="id">The ID of the advert to retrieve.</param>
        /// <returns>The AdvertDbo object if found, or null if not found.</returns>
        GetAdvertDto GetAdvert(int id);

        /// <summary>
        /// Adds a new advert.
        /// </summary>
        /// <param name="advert">The AddAdvertDto object containing the advert data.</param>
        /// <returns>The ID of the added advert.</returns>
        int AddAdvert(AddAdvertDto advert);
    }
}
