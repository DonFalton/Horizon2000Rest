using Horizon2000Rest.Entity.Models;

namespace Horizon2000Rest.Entity.Interfaces
{
    public interface ICourseRepository
    {
        /// <summary>
        /// Retrieves a CourseDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the course.</param>
        /// <returns>The CourseDbo entity.</returns>
        CourseDbo Get(int id);

        /// <summary>
        /// Finds a CourseDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the course.</param>
        /// <returns>The CourseDbo entity if found, otherwise null.</returns>
        CourseDbo Find(int id);

        /// <summary>
        /// Retrieves all CourseDbo entities.
        /// </summary>
        /// <returns>A list of CourseDbo entities.</returns>
        List<CourseDbo> GetAll();

        /// <summary>
        /// Updates an existing CourseDbo entity.
        /// </summary>
        /// <param name="advert">The CourseDbo entity to be updated.</param>
        void Update(CourseDbo advert);

        /// <summary>
        /// Deletes a CourseDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the course to be deleted.</param>
        void Delete(int id);

        /// <summary>
        /// Adds a new CourseDbo entity.
        /// </summary>
        /// <param name="advert">The CourseDbo entity to be added.</param>
        void Add(CourseDbo advert);
    }
}
