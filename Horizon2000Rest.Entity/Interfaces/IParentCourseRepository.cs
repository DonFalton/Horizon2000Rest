using Horizon2000Rest.Entity.Models;

namespace Horizon2000Rest.Entity.Interfaces
{
    public interface IParentCourseRepository
    {
        /// <summary>
        /// Retrieves a ParentCourseDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the parent course.</param>
        /// <returns>The ParentCourseDbo entity.</returns>
        ParentCourseDbo Get(int id);

        /// <summary>
        /// Finds a ParentCourseDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the parent course.</param>
        /// <returns>The ParentCourseDbo entity if found, otherwise null.</returns>
        ParentCourseDbo Find(int id);

        /// <summary>
        /// Retrieves all ParentCourseDbo entities.
        /// </summary>
        /// <returns>A list of ParentCourseDbo entities.</returns>
        List<ParentCourseDbo> GetAll();

        /// <summary>
        /// Updates an existing ParentCourseDbo entity.
        /// </summary>
        /// <param name="advert">The ParentCourseDbo entity to be updated.</param>
        void Update(ParentCourseDbo advert);

        /// <summary>
        /// Deletes a ParentCourseDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the parent course to be deleted.</param>
        void Delete(int id);

        /// <summary>
        /// Adds a new ParentCourseDbo entity.
        /// </summary>
        /// <param name="advert">The ParentCourseDbo entity to be added.</param>
        void Add(ParentCourseDbo advert);
    }
}
