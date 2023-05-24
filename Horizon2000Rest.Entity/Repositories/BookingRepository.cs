using Horizon2000Rest.Entity.Data;
using Horizon2000Rest.Entity.Interfaces;
using Horizon2000Rest.Entity.Models;

namespace Horizon2000REST.Entity.Repositories
{
    /// <inheritdoc/>
    /// <seealso cref="IBookingRepository"/>
    public class BookingRepository : IBookingRepository
    {
        /// <summary>
        /// Database context
        /// </summary>
        private readonly DataContext _dataContext;

        public BookingRepository(DataContext horizonContext)
        {
            _dataContext = horizonContext;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Retrieves a BookingDbo object by its ID
        /// </summary>
        public BookingDbo Get(int id)
        {
            return _dataContext.Bookings.FirstOrDefault(x => x.ID == id) ??
                throw new ArgumentNullException("Booking not found");
        }

        /// <inheritdoc/>
        /// <summary>
        /// Finds a BookingDbo object by its ID
        /// </summary>
        public BookingDbo Find(int id) =>
            _dataContext.Bookings.FirstOrDefault(x => x.ID == id);

        /// <inheritdoc/>
        /// <summary>
        /// Retrieves all active BookingDbo objects
        /// </summary>
        public List<BookingDbo> GetAll() =>
            _dataContext.Bookings
                .Where(x => x.IsActive)
                .ToList();

        /// <inheritdoc/>
        /// <summary>
        /// Updates a BookingDbo object
        /// </summary>
        public void Update(BookingDbo booking)
        {
            _dataContext.Update(booking);
        }

        /// <inheritdoc/>
        /// <summary>
        /// Deletes a BookingDbo object by setting IsActive to false
        /// </summary>
        public void Delete(int id)
        {
            var booking = Get(id);
            booking.IsActive = false;

            Update(booking);
        }

        /// <inheritdoc/>
        /// <summary>
        /// Adds a new BookingDbo object
        /// </summary>
        public void Add(BookingDbo booking)
        {
            _dataContext.Bookings.Add(booking);
        }
    }
}
