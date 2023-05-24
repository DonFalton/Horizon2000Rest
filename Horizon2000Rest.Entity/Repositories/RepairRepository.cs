using Horizon2000Rest.Entity.Data;
using Horizon2000Rest.Entity.Interfaces;
using Horizon2000Rest.Entity.Models;

namespace Horizon2000REST.Entity.Repositories
{
    /// <inheritdoc/>
    /// <seealso cref="IRepairRepository"/>
    /// <summary>
    /// Repository class for managing repairs.
    /// </summary>
    public class RepairRepository : IRepairRepository
    {
        /// <summary>
        /// Database context.
        /// </summary>
        private readonly DataContext _dataContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="RepairRepository"/> class.
        /// </summary>
        /// <param name="horizonContext">The database context.</param>
        public RepairRepository(DataContext horizonContext)
        {
            _dataContext = horizonContext;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Retrieves a RepairDbo object by its ID.
        /// </summary>
        /// <param name="id">The ID of the repair to retrieve.</param>
        /// <returns>The retrieved RepairDbo object.</returns>
        public RepairDbo Get(int id)
        {
            return _dataContext.Repairs.FirstOrDefault(x => x.ID == id) ??
                throw new ArgumentNullException("Repair not found");
        }

        /// <inheritdoc/>
        /// <summary>
        /// Finds a RepairDbo object by its ID.
        /// </summary>
        /// <param name="id">The ID of the repair to find.</param>
        /// <returns>The found RepairDbo object, or null if not found.</returns>
        public RepairDbo Find(int id) =>
            _dataContext.Repairs.FirstOrDefault(x => x.ID == id);

        /// <inheritdoc/>
        /// <summary>
        /// Retrieves all active RepairDbo objects.
        /// </summary>
        /// <returns>A list of active RepairDbo objects.</returns>
        public List<RepairDbo> GetAll() =>
            _dataContext.Repairs
                .Where(x => x.IsActive)
                .ToList();

        /// <inheritdoc/>
        /// <summary>
        /// Updates a RepairDbo object.
        /// </summary>
        /// <param name="repair">The RepairDbo object to update.</param>
        public void Update(RepairDbo repair)
        {
            _dataContext.Update(repair);
        }

        /// <inheritdoc/>
        /// <summary>
        /// Deletes a RepairDbo object by setting IsActive to false.
        /// </summary>
        /// <param name="id">The ID of the repair to delete.</param>
        public void Delete(int id)
        {
            var repair = Get(id);
            repair.IsActive = false;

            Update(repair);
        }

        /// <inheritdoc/>
        /// <summary>
        /// Adds a new RepairDbo object.
        /// </summary>
        /// <param name="repair">The RepairDbo object to add.</param>
        public void Add(RepairDbo repair)
        {
            _dataContext.Repairs.Add(repair);
        }
    }
}
