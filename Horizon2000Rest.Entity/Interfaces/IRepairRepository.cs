using Horizon2000Rest.Entity.Models;

namespace Horizon2000Rest.Entity.Interfaces
{
    public interface IRepairRepository
    {
        /// <summary>
        /// Retrieves a RepairDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the repair.</param>
        /// <returns>The RepairDbo entity.</returns>
        RepairDbo Get(int id);

        /// <summary>
        /// Finds a RepairDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the repair.</param>
        /// <returns>The RepairDbo entity if found, otherwise null.</returns>
        RepairDbo Find(int id);

        /// <summary>
        /// Retrieves all RepairDbo entities.
        /// </summary>
        /// <returns>A list of RepairDbo entities.</returns>
        List<RepairDbo> GetAll();

        /// <summary>
        /// Updates an existing RepairDbo entity.
        /// </summary>
        /// <param name="advert">The RepairDbo entity to be updated.</param>
        void Update(RepairDbo advert);

        /// <summary>
        /// Deletes a RepairDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the repair to be deleted.</param>
        void Delete(int id);

        /// <summary>
        /// Adds a new RepairDbo entity.
        /// </summary>
        /// <param name="advert">The RepairDbo entity to be added.</param>
        void Add(RepairDbo advert);
    }
}
