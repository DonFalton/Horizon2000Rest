using Horizon2000Rest.Entity.Data;
using Horizon2000Rest.Entity.Interfaces;
using Horizon2000Rest.Entity.Models;

namespace Horizon2000REST.Entity.Repositories
{
    /// <inheritdoc/>
    /// <seealso cref="IUserRoleRepository"/>
    /// <summary>
    /// Repository class for managing user roles.
    /// </summary>
    public class UserRoleRepository : IUserRoleRepository
    {
        /// <summary>
        /// Database context.
        /// </summary>
        private readonly DataContext _dataContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRoleRepository"/> class.
        /// </summary>
        /// <param name="horizonContext">The database context.</param>
        public UserRoleRepository(DataContext horizonContext)
        {
            _dataContext = horizonContext;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Retrieves a UserRoleDbo object by its ID.
        /// </summary>
        /// <param name="id">The ID of the user role to retrieve.</param>
        /// <returns>The retrieved UserRoleDbo object.</returns>
        public UserRoleDbo Get(int id)
        {
            return _dataContext.UserRoles.FirstOrDefault(x => x.ID == id) ??
                throw new ArgumentNullException("UserRole not found");
        }

        /// <inheritdoc/>
        /// <summary>
        /// Finds a UserRoleDbo object by its ID.
        /// </summary>
        /// <param name="id">The ID of the user role to find.</param>
        /// <returns>The found UserRoleDbo object, or null if not found.</returns>
        public UserRoleDbo Find(int id) =>
            _dataContext.UserRoles.FirstOrDefault(x => x.ID == id);

        /// <inheritdoc/>
        /// <summary>
        /// Retrieves all active UserRoleDbo objects.
        /// </summary>
        /// <returns>A list of active UserRoleDbo objects.</returns>
        public List<UserRoleDbo> GetAll() =>
            _dataContext.UserRoles
                .Where(x => x.IsActive)
                .ToList();

        /// <inheritdoc/>
        /// <summary>
        /// Updates a UserRoleDbo object.
        /// </summary>
        /// <param name="userRole">The UserRoleDbo object to update.</param>
        public void Update(UserRoleDbo userRole)
        {
            _dataContext.Update(userRole);
        }

        /// <inheritdoc/>
        /// <summary>
        /// Deletes a UserRoleDbo object by setting IsActive to false.
        /// </summary>
        /// <param name="id">The ID of the user role to delete.</param>
        public void Delete(int id)
        {
            var userRole = Get(id);
            userRole.IsActive = false;

            Update(userRole);
        }

        /// <inheritdoc/>
        /// <summary>
        /// Adds a new UserRoleDbo object.
        /// </summary>
        /// <param name="userRole">The UserRoleDbo object to add.</param>
        public void Add(UserRoleDbo userRole)
        {
            _dataContext.UserRoles.Add(userRole);
        }
    }
}
