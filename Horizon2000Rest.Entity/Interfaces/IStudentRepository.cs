using Horizon2000Rest.Entity.Models;

namespace Horizon2000Rest.Entity.Interfaces
{
    public interface IStudentRepository
    {
        /// <summary>
        /// Retrieves a StudentDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the student.</param>
        /// <returns>The StudentDbo entity.</returns>
        StudentDbo Get(int id);

        /// <summary>
        /// Finds a StudentDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the student.</param>
        /// <returns>The StudentDbo entity if found, otherwise null.</returns>
        StudentDbo Find(int id);

        /// <summary>
        /// Retrieves all StudentDbo entities.
        /// </summary>
        /// <returns>A list of StudentDbo entities.</returns>
        List<StudentDbo> GetAll();

        /// <summary>
        /// Updates an existing StudentDbo entity.
        /// </summary>
        /// <param name="advert">The StudentDbo entity to be updated.</param>
        void Update(StudentDbo advert);

        /// <summary>
        /// Deletes a StudentDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the student to be deleted.</param>
        void Delete(int id);

        /// <summary>
        /// Adds a new StudentDbo entity.
        /// </summary>
        /// <param name="advert">The StudentDbo entity to be added.</param>
        void Add(StudentDbo advert);

        /// <summary>
        /// Saves the changes made to the repository.
        /// </summary>
        void Save();
    }
}
