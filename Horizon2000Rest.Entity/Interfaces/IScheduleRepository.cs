using Horizon2000Rest.Entity.Models;

namespace Horizon2000Rest.Entity.Interfaces
{
    public interface IScheduleRepository
    {
        /// <summary>
        /// Retrieves a ScheduleDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the schedule.</param>
        /// <returns>The ScheduleDbo entity.</returns>
        ScheduleDbo Get(int id);

        /// <summary>
        /// Finds a ScheduleDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the schedule.</param>
        /// <returns>The ScheduleDbo entity if found, otherwise null.</returns>
        ScheduleDbo Find(int id);

        /// <summary>
        /// Retrieves all ScheduleDbo entities.
        /// </summary>
        /// <returns>A list of ScheduleDbo entities.</returns>
        List<ScheduleDbo> GetAll();

        /// <summary>
        /// Updates an existing ScheduleDbo entity.
        /// </summary>
        /// <param name="advert">The ScheduleDbo entity to be updated.</param>
        void Update(ScheduleDbo advert);

        /// <summary>
        /// Deletes a ScheduleDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the schedule to be deleted.</param>
        void Delete(int id);

        /// <summary>
        /// Adds a new ScheduleDbo entity.
        /// </summary>
        /// <param name="advert">The ScheduleDbo entity to be added.</param>
        void Add(ScheduleDbo advert);
    }
}
