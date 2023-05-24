using Horizon2000Rest.Entity.Data;
using Horizon2000Rest.Entity.Interfaces;
using Horizon2000Rest.Entity.Models;

namespace Horizon2000REST.Entity.Repositories
{
    /// <inheritdoc/>
    /// <seealso cref="IUserRepository"/>
    /// <summary>
    /// Repository class for managing users.
    /// </summary>
    public class UserRepository : IUserRepository
    {
        /// <summary>
        /// Database context.
        /// </summary>
        private readonly DataContext _dataContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRepository"/> class.
        /// </summary>
        /// <param name="horizonContext">The database context.</param>
        public UserRepository(DataContext horizonContext)
        {
            _dataContext = horizonContext;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Retrieves a UserDbo object by its ID.
        /// </summary>
        /// <param name="id">The ID of the user to retrieve.</param>
        /// <returns>The retrieved UserDbo object.</returns>
        public UserDbo Get(int id)
        {
            return _dataContext.Users.FirstOrDefault(x => x.ID == id) ??
                throw new ArgumentNullException("User not found");
        }

        /// <inheritdoc/>
        /// <summary>
        /// Finds a UserDbo object by its ID.
        /// </summary>
        /// <param name="id">The ID of the user to find.</param>
        /// <returns>The found UserDbo object, or null if not found.</returns>
        public UserDbo Find(int id) =>
            _dataContext.Users.FirstOrDefault(x => x.ID == id);

        /// <inheritdoc/>
        /// <summary>
        /// Retrieves all active UserDbo objects.
        /// </summary>
        /// <returns>A list of active UserDbo objects.</returns>
        public List<UserDbo> GetAll() =>
            _dataContext.Users
                .Where(x => x.IsActive)
                .ToList();

        /// <inheritdoc/>
        /// <summary>
        /// Updates a UserDbo object.
        /// </summary>
        /// <param name="user">The UserDbo object to update.</param>
        public void Update(UserDbo user)
        {
            _dataContext.Update(user);
        }

        /// <inheritdoc/>
        /// <summary>
        /// Deletes a UserDbo object by setting IsActive to false.
        /// </summary>
        /// <param name="id">The ID of the user to delete.</param>
        public void Delete(int id)
        {
            var user = Get(id);
            user.IsActive = false;

            Update(user);
        }

        /// <inheritdoc/>
        /// <summary>
        /// Adds a new UserDbo object.
        /// </summary>
        /// <param name="user">The UserDbo object to add.</param>
        public void Add(UserDbo user)
        {
            _dataContext.Users.Add(user);
        }
    }
}
