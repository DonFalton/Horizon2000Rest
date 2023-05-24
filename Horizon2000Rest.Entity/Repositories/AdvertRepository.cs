using Horizon2000Rest.Entity.Data; // Importing the namespace that contains the application's data context.
using Horizon2000Rest.Entity.Interfaces; // Importing the namespace that contains the interface definition.
using Horizon2000Rest.Entity.Models; // Importing the namespace that contains the model for the Advert entity.

namespace Horizon2000REST.Entity.Repositories
{
    /// <inheritdoc/>
    /// <seealso cref="IAdvertRepository"/>
    public class AdvertRepository : IAdvertRepository
    {
        /// <summary>
        /// Database context
        /// </summary>
        private readonly DataContext _dataContext; // Declaring a private field to hold an instance of the HorizonContext.

        public AdvertRepository(DataContext horizonContext) // Constructor for the AdvertRepository class that takes a HorizonContext instance as a parameter.
        {
            _dataContext = horizonContext; // Assigning the provided HorizonContext instance to the private field.
        }

        /// <inheritdoc/>
        public AdvertDbo Get(int id) // Implementation of the Get method defined in the IAdvertRepository interface.
        {
            return _dataContext.Adverts.FirstOrDefault(x => x.ID == id) ?? throw new ArgumentNullException("Advert not found"); // Retrieving the first AdvertDbo object from the data context where the ID matches the provided id. If no object is found, it throws an ArgumentNullException.
        }

        /// <inheritdoc/>
        public AdvertDbo Find(int id) => _dataContext.Adverts.FirstOrDefault(x => x.ID == id); // Implementation of the Find method defined in the IAdvertRepository interface. It retrieves the first AdvertDbo object from the data context where the ID matches the provided id.

        /// <inheritdoc/>
        public List<AdvertDbo> GetAll() => _dataContext.Adverts.Where(x => x.IsActive).ToList(); // Implementation of the GetAll method defined in the IAdvertRepository interface. It retrieves a list of AdvertDbo objects from the data context where IsActive is true.

        /// <inheritdoc/>
        public void Update(AdvertDbo advert) // Implementation of the Update method defined in the IAdvertRepository interface.
        {
            _dataContext.Update(advert); // Marking the provided advert object as updated in the data context.
        }

        /// <inheritdoc/>
        public void Delete(int id) // Implementation of the Delete method defined in the IAdvertRepository interface.
        {
            var advert = Get(id); // Retrieving the AdvertDbo object with the provided id.
            advert.IsActive = false; // Setting the IsActive property of the advert object to false.

            Update(advert); // Calling the Update method to mark the advert object as updated in the data context.
        }

        /// <inheritdoc/>
        public void Add(AdvertDbo advert) // Implementation of the Add method defined in the IAdvertRepository interface.
        {
            _dataContext.Adverts.Add(advert); // Adding the advert object to the data context.
        }
    }
}
