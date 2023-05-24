using Horizon2000Rest.Entity.Models;

namespace Horizon2000Rest.Entity.Interfaces
{
    public interface IStudentCourseSkillCardRepository
    {
        /// <summary>
        /// Retrieves a StudentCourseSkillCardDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the student course skill card.</param>
        /// <returns>The StudentCourseSkillCardDbo entity.</returns>
        StudentCourseSkillCardDbo Get(int id);

        /// <summary>
        /// Finds a StudentCourseSkillCardDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the student course skill card.</param>
        /// <returns>The StudentCourseSkillCardDbo entity if found, otherwise null.</returns>
        StudentCourseSkillCardDbo Find(int id);

        /// <summary>
        /// Retrieves all StudentCourseSkillCardDbo entities.
        /// </summary>
        /// <returns>A list of StudentCourseSkillCardDbo entities.</returns>
        List<StudentCourseSkillCardDbo> GetAll();

        /// <summary>
        /// Updates an existing StudentCourseSkillCardDbo entity.
        /// </summary>
        /// <param name="advert">The StudentCourseSkillCardDbo entity to be updated.</param>
        void Update(StudentCourseSkillCardDbo advert);

        /// <summary>
        /// Deletes a StudentCourseSkillCardDbo entity by its ID.
        /// </summary>
        /// <param name="id">The ID of the student course skill card to be deleted.</param>
        void Delete(int id);

        /// <summary>
        /// Adds a new StudentCourseSkillCardDbo entity.
        /// </summary>
        /// <param name="advert">The StudentCourseSkillCardDbo entity to be added.</param>
        void Add(StudentCourseSkillCardDbo advert);
    }
}
