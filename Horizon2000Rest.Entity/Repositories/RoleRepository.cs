using Horizon2000Rest.Entity.Data;
using Horizon2000Rest.Entity.Interfaces;
using Horizon2000Rest.Entity.Models;

namespace Horizon2000REST.Entity.Repositories
{
    /// <inheritdoc/>
    /// <seealso cref="IRoleRepository"/>
    /// <summary>
    /// Repository class for managing roles.
    /// </summary>
    public class RoleRepository : IRoleRepository
    {
        /// <summary>
        /// Database context.
        /// </summary>
        private readonly DataContext _dataContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleRepository"/> class.
        /// </summary>
        /// <param name="horizonContext">The database context.</param>
        public RoleRepository(DataContext horizonContext)
        {
            _dataContext = horizonContext;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Retrieves a RoleDbo object by its ID.
        /// </summary>
        /// <param name="id">The ID of the role to retrieve.</param>
        /// <returns>The retrieved RoleDbo object.</returns>
        public RoleDbo Get(int id)
        {
            return _dataContext.Roles.FirstOrDefault(x => x.ID == id) ??
                throw new ArgumentNullException("Role not found");
        }

        /// <inheritdoc/>
        /// <summary>
        /// Finds a RoleDbo object by its ID.
        /// </summary>
        /// <param name="id">The ID of the role to find.</param>
        /// <returns>The found RoleDbo object, or null if not found.</returns>
        public RoleDbo Find(int id) =>
            _dataContext.Roles.FirstOrDefault(x => x.ID == id);

        /// <inheritdoc/>
        /// <summary>
        /// Retrieves all active RoleDbo objects.
        /// </summary>
        /// <returns>A list of active RoleDbo objects.</returns>
        public List<RoleDbo> GetAll() =>
            _dataContext.Roles
                .Where(x => x.IsActive)
                .ToList();

        /// <inheritdoc/>
        /// <summary>
        /// Updates a RoleDbo object.
        /// </summary>
        /// <param name="role">The RoleDbo object to update.</param>
        public void Update(RoleDbo role)
        {
            _dataContext.Update(role);
        }

        /// <inheritdoc/>
        /// <summary>
        /// Deletes a RoleDbo object by setting IsActive to false.
        /// </summary>
        /// <param name="id">The ID of the role to delete.</param>
        public void Delete(int id)
        {
            var role = Get(id);
            role.IsActive = false;

            Update(role);
        }

        /// <inheritdoc/>
        /// <summary>
        /// Adds a new RoleDbo object.
        /// </summary>
        /// <param name="role">The RoleDbo object to add.</param>
        public void Add(RoleDbo role)
        {
            _dataContext.Roles.Add(role);
        }
    }
}
