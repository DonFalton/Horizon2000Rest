using Horizon2000Rest.Entity.Models;

namespace Horizon2000Rest.Entity.Interfaces
{
    /// <summary>
    /// Provides methods for accessing the 'Booking' data.
    /// </summary>
    public interface IBookingRepository
    {
        /// <summary>
        /// Retrieves a BookingDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the booking.</param>
        /// <returns>The BookingDbo entity.</returns>
        BookingDbo Get(int id);

        /// <summary>
        /// Finds a BookingDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the booking.</param>
        /// <returns>The BookingDbo entity if found, otherwise null.</returns>
        BookingDbo Find(int id);

        /// <summary>
        /// Retrieves all BookingDbo entities.
        /// </summary>
        /// <returns>A list of BookingDbo entities.</returns>
        List<BookingDbo> GetAll();

        /// <summary>
        /// Updates an existing BookingDbo entity.
        /// </summary>
        /// <param name="advert">The BookingDbo entity to be updated.</param>
        void Update(BookingDbo advert);

        /// <summary>
        /// Deletes a BookingDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the booking to be deleted.</param>
        void Delete(int id);

        /// <summary>
        /// Adds a new BookingDbo entity.
        /// </summary>
        /// <param name="advert">The BookingDbo entity to be added.</param>
        void Add(BookingDbo advert);
    }
}
