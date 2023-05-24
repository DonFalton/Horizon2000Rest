using Horizon2000Rest.Entity.Data;
using Horizon2000Rest.Entity.Interfaces;
using Horizon2000Rest.Entity.Models;

namespace Horizon2000REST.Entity.Repositories
{
    /// <inheritdoc/>
    /// <seealso cref="IStudentCourseSkillCardRepository"/>
    /// <summary>
    /// Repository class for managing student course skill cards.
    /// </summary>
    public class StudentCourseSkillCardRepository : IStudentCourseSkillCardRepository
    {
        /// <summary>
        /// Database context.
        /// </summary>
        private readonly DataContext _dataContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="StudentCourseSkillCardRepository"/> class.
        /// </summary>
        /// <param name="horizonContext">The database context.</param>
        public StudentCourseSkillCardRepository(DataContext horizonContext)
        {
            _dataContext = horizonContext;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Retrieves a StudentCourseSkillCardDbo object by its ID.
        /// </summary>
        /// <param name="id">The ID of the student course skill card to retrieve.</param>
        /// <returns>The retrieved StudentCourseSkillCardDbo object.</returns>
        public StudentCourseSkillCardDbo Get(int id)
        {
            return _dataContext.StudentCourseSkillCards.FirstOrDefault(x => x.ID == id) ??
                throw new ArgumentNullException("StudentCourseSkillCard not found");
        }

        /// <inheritdoc/>
        /// <summary>
        /// Finds a StudentCourseSkillCardDbo object by its ID.
        /// </summary>
        /// <param name="id">The ID of the student course skill card to find.</param>
        /// <returns>The found StudentCourseSkillCardDbo object, or null if not found.</returns>
        public StudentCourseSkillCardDbo Find(int id) =>
            _dataContext.StudentCourseSkillCards.FirstOrDefault(x => x.ID == id);

        /// <inheritdoc/>
        /// <summary>
        /// Retrieves all active StudentCourseSkillCardDbo objects.
        /// </summary>
        /// <returns>A list of active StudentCourseSkillCardDbo objects.</returns>
        public List<StudentCourseSkillCardDbo> GetAll() =>
            _dataContext.StudentCourseSkillCards
                .Where(x => x.IsActive)
                .ToList();

        /// <inheritdoc/>
        /// <summary>
        /// Updates a StudentCourseSkillCardDbo object.
        /// </summary>
        /// <param name="studentCourseSkillCard">The StudentCourseSkillCardDbo object to update.</param>
        public void Update(StudentCourseSkillCardDbo studentCourseSkillCard)
        {
            _dataContext.Update(studentCourseSkillCard);
        }

        /// <inheritdoc/>
        /// <summary>
        /// Deletes a StudentCourseSkillCardDbo object by setting IsActive to false.
        /// </summary>
        /// <param name="id">The ID of the student course skill card to delete.</param>
        public void Delete(int id)
        {
            var studentCourseSkillCard = Get(id);
            studentCourseSkillCard.IsActive = false;

            Update(studentCourseSkillCard);
        }

        /// <inheritdoc/>
        /// <summary>
        /// Adds a new StudentCourseSkillCardDbo object.
        /// </summary>
        /// <param name="studentCourseSkillCard">The StudentCourseSkillCardDbo object to add.</param>
        public void Add(StudentCourseSkillCardDbo studentCourseSkillCard)
        {
            _dataContext.StudentCourseSkillCards.Add(studentCourseSkillCard);
        }
    }
}
