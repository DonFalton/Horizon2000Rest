using Horizon2000Rest.Entity.Data;
using Horizon2000Rest.Entity.Interfaces;
using Horizon2000Rest.Entity.Models;

namespace Horizon2000REST.Entity.Repositories
{
    /// <inheritdoc/>
    /// <seealso cref="IScheduleRepository"/>
    /// <summary>
    /// Repository class for managing schedules.
    /// </summary>
    public class ScheduleRepository : IScheduleRepository
    {
        /// <summary>
        /// Database context.
        /// </summary>
        private readonly DataContext _dataContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleRepository"/> class.
        /// </summary>
        /// <param name="horizonContext">The database context.</param>
        public ScheduleRepository(DataContext horizonContext)
        {
            _dataContext = horizonContext;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Retrieves a ScheduleDbo object by its ID.
        /// </summary>
        /// <param name="id">The ID of the schedule to retrieve.</param>
        /// <returns>The retrieved ScheduleDbo object.</returns>
        public ScheduleDbo Get(int id)
        {
            return _dataContext.Schedules.FirstOrDefault(x => x.ID == id) ??
                throw new ArgumentNullException("Schedule not found");
        }

        /// <inheritdoc/>
        /// <summary>
        /// Finds a ScheduleDbo object by its ID.
        /// </summary>
        /// <param name="id">The ID of the schedule to find.</param>
        /// <returns>The found ScheduleDbo object, or null if not found.</returns>
        public ScheduleDbo Find(int id) =>
            _dataContext.Schedules.FirstOrDefault(x => x.ID == id);

        /// <inheritdoc/>
        /// <summary>
        /// Retrieves all active ScheduleDbo objects.
        /// </summary>
        /// <returns>A list of active ScheduleDbo objects.</returns>
        public List<ScheduleDbo> GetAll() =>
            _dataContext.Schedules
                .Where(x => x.IsActive)
                .ToList();

        /// <inheritdoc/>
        /// <summary>
        /// Updates a ScheduleDbo object.
        /// </summary>
        /// <param name="schedule">The ScheduleDbo object to update.</param>
        public void Update(ScheduleDbo schedule)
        {
            _dataContext.Update(schedule);
        }

        /// <inheritdoc/>
        /// <summary>
        /// Deletes a ScheduleDbo object by setting IsActive to false.
        /// </summary>
        /// <param name="id">The ID of the schedule to delete.</param>
        public void Delete(int id)
        {
            var schedule = Get(id);
            schedule.IsActive = false;

            Update(schedule);
        }

        /// <inheritdoc/>
        /// <summary>
        /// Adds a new ScheduleDbo object.
        /// </summary>
        /// <param name="schedule">The ScheduleDbo object to add.</param>
        public void Add(ScheduleDbo schedule)
        {
            _dataContext.Schedules.Add(schedule);
        }
    }
}
