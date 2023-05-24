using Horizon2000Rest.Entity.Data;
using Horizon2000Rest.Entity.Interfaces;
using Horizon2000Rest.Entity.Models;
using System;

namespace Horizon2000REST.Entity.Repositories
{
    /// <inheritdoc/>
    /// <seealso cref="IStudentRepository"/>
    /// <summary>
    /// Repository class for managing students.
    /// </summary>
    public class StudentRepository : IStudentRepository
    {
        /// <summary>
        /// Database context.
        /// </summary>
        private readonly DataContext _dataContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="StudentRepository"/> class.
        /// </summary>
        /// <param name="horizonContext">The database context.</param>
        public StudentRepository(DataContext horizonContext)
        {
            _dataContext = horizonContext;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Retrieves a StudentDbo object by its ID.
        /// </summary>
        /// <param name="id">The ID of the student to retrieve.</param>
        /// <returns>The retrieved StudentDbo object.</returns>
        public StudentDbo Get(int id)
        {
            return _dataContext.Students.FirstOrDefault(x => x.ID == id) ??
                throw new ArgumentNullException("Student not found");
        }

        /// <inheritdoc/>
        /// <summary>
        /// Finds a StudentDbo object by its ID.
        /// </summary>
        /// <param name="id">The ID of the student to find.</param>
        /// <returns>The found StudentDbo object, or null if not found.</returns>
        public StudentDbo Find(int id) =>
            _dataContext.Students.FirstOrDefault(x => x.ID == id);

        /// <inheritdoc/>
        /// <summary>
        /// Retrieves all active StudentDbo objects.
        /// </summary>
        /// <returns>A list of active StudentDbo objects.</returns>
        public List<StudentDbo> GetAll() =>
            _dataContext.Students
                .Where(x => x.IsActive)
                .ToList();

        /// <inheritdoc/>
        /// <summary>
        /// Updates a StudentDbo object.
        /// </summary>
        /// <param name="student">The StudentDbo object to update.</param>
        public void Update(StudentDbo student)
        {
            _dataContext.Update(student);
        }

        /// <inheritdoc/>
        /// <summary>
        /// Deletes a StudentDbo object by setting IsActive to false.
        /// </summary>
        /// <param name="id">The ID of the student to delete.</param>
        public void Delete(int id)
        {
            var student = Get(id);
            student.IsActive = false;

            Update(student);
        }

        /// <inheritdoc/>
        /// <summary>
        /// Adds a new StudentDbo object.
        /// </summary>
        /// <param name="student">The StudentDbo object to add.</param>
        public void Add(StudentDbo student)
        {
            _dataContext.Students.Add(student);
        }
    }
}
