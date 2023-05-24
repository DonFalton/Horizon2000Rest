using Horizon2000Rest.Entity.Data;
using Horizon2000Rest.Entity.Interfaces;
using Horizon2000Rest.Entity.Models;

namespace Horizon2000REST.Entity.Repositories
{
    /// <inheritdoc/>
    /// <seealso cref="IUserSessionRepository"/>
    /// <summary>
    /// Repository class for managing user sessions.
    /// </summary>
    public class UserSessionRepository : IUserSessionRepository
    {
        /// <summary>
        /// Database context.
        /// </summary>
        private readonly DataContext _dataContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSessionRepository"/> class.
        /// </summary>
        /// <param name="horizonContext">The database context.</param>
        public UserSessionRepository(DataContext horizonContext)
        {
            _dataContext = horizonContext;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Retrieves a UserSessionDbo object by its ID.
        /// </summary>
        /// <param name="id">The ID of the user session to retrieve.</param>
        /// <returns>The retrieved UserSessionDbo object.</returns>
        public UserSessionDbo Get(int id)
        {
            return _dataContext.UserSessions.FirstOrDefault(x => x.ID == id) ??
                throw new ArgumentNullException("UserSession not found");
        }

        /// <inheritdoc/>
        /// <summary>
        /// Finds a UserSessionDbo object by its ID.
        /// </summary>
        /// <param name="id">The ID of the user session to find.</param>
        /// <returns>The found UserSessionDbo object, or null if not found.</returns>
        public UserSessionDbo Find(int id) =>
            _dataContext.UserSessions.FirstOrDefault(x => x.ID == id);

        /// <inheritdoc/>
        /// <summary>
        /// Retrieves all active UserSessionDbo objects.
        /// </summary>
        /// <returns>A list of active UserSessionDbo objects.</returns>
        public List<UserSessionDbo> GetAll() =>
            _dataContext.UserSessions
                .Where(x => x.IsActive)
                .ToList();

        /// <inheritdoc/>
        /// <summary>
        /// Updates a UserSessionDbo object.
        /// </summary>
        /// <param name="userSession">The UserSessionDbo object to update.</param>
        public void Update(UserSessionDbo userSession)
        {
            _dataContext.Update(userSession);
        }

        /// <inheritdoc/>
        /// <summary>
        /// Deletes a UserSessionDbo object by setting IsActive to false.
        /// </summary>
        /// <param name="id">The ID of the user session to delete.</param>
        public void Delete(int id)
        {
            var userSession = Get(id);
            userSession.IsActive = false;

            Update(userSession);
        }

        /// <inheritdoc/>
        /// <summary>
        /// Adds a new UserSessionDbo object.
        /// </summary>
        /// <param name="userSession">The UserSessionDbo object to add.</param>
        public void Add(UserSessionDbo userSession)
        {
            _dataContext.UserSessions.Add(userSession);
        }
    }
}
