using Horizon2000Rest.Entity.Data;
using Horizon2000Rest.Entity.Interfaces;
using Horizon2000Rest.Entity.Models;

namespace Horizon2000REST.Entity.Repositories
{
    /// <inheritdoc/>
    /// <seealso cref="IClientRepository"/>
    public class ClientRepository : IClientRepository
    {
        /// <summary>
        /// Database context
        /// </summary>
        private readonly DataContext _dataContext;

        public ClientRepository(DataContext horizonContext)
        {
            _dataContext = horizonContext;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Retrieves a ClientDbo object by its ID
        /// </summary>
        public ClientDbo Get(int id)
        {
            return _dataContext.Clients.FirstOrDefault(x => x.ID == id) ??
                throw new ArgumentNullException("Client not found");
        }

        /// <inheritdoc/>
        /// <summary>
        /// Finds a ClientDbo object by its ID
        /// </summary>
        public ClientDbo Find(int id) =>
            _dataContext.Clients.FirstOrDefault(x => x.ID == id);

        /// <inheritdoc/>
        /// <summary>
        /// Retrieves all active ClientDbo objects
        /// </summary>
        public List<ClientDbo> GetAll() =>
            _dataContext.Clients
                .Where(x => x.IsActive)
                .ToList();

        /// <inheritdoc/>
        /// <summary>
        /// Updates a ClientDbo object
        /// </summary>
        public void Update(ClientDbo client)
        {
            _dataContext.Update(client);
        }

        /// <inheritdoc/>
        /// <summary>
        /// Deletes a ClientDbo object by setting IsActive to false
        /// </summary>
        public void Delete(int id)
        {
            var client = Get(id);
            client.IsActive = false;

            Update(client);
        }

        /// <inheritdoc/>
        /// <summary>
        /// Adds a new ClientDbo object
        /// </summary>
        public void Add(ClientDbo client)
        {
            _dataContext.Clients.Add(client);
        }
    }
}
