using AutoMapper;
using Horizon2000Rest.Core.Interfaces;
using Horizon2000Rest.Entity.Data;
using Horizon2000Rest.Entity.Interfaces;
using Horizon2000Rest.Entity.Models;
using Horizon2000Rest.Core.Models.Advert;

namespace Horizon2000Rest.Core.Workers
{
    /// <summary>
    /// Implementation of the IAdvertWorker interface for managing advert operations.
    /// </summary>
    public class AdvertWorker : IAdvertWorker
    {
        private readonly DataContext _dataContext;
        private readonly IAdvertRepository _advertRepository;
        private readonly IMapper _mapper;

        public AdvertWorker(DataContext dataContext, IAdvertRepository advertRepository, IMapper mapper)
        {
            _dataContext = dataContext ?? throw new ArgumentNullException(nameof(dataContext));
            _advertRepository = advertRepository ?? throw new ArgumentNullException(nameof(advertRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <inheritdoc/>
        public GetAdvertDto GetAdvert(int id)
        {
            var advertDbo = _advertRepository.Get(id);
            return _mapper.Map<GetAdvertDto>(advertDbo);
        }

        /// <inheritdoc/>
        public int AddAdvert(AddAdvertDto advert)
        {
            if (advert == null)
                throw new ArgumentNullException(nameof(advert));

            if (string.IsNullOrWhiteSpace(advert.FileName))
                throw new ArgumentException("File name not found");

            // Map the DTO to the corresponding entity
            var advertDbo = _mapper.Map<AdvertDbo>(advert);

            using (var transaction = _dataContext.Database.BeginTransaction())
            {
                try
                {
                    // Add the entity to the database
                    _advertRepository.Add(advertDbo);

                    // Save the changes
                    _dataContext.SaveChanges();
                    transaction.Commit();

                    return advertDbo.ID;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Advert could not be saved", ex);
                }
            }
        }

        /// <inheritdoc/>
        public void DeactivateAdvert(int id)
        {
            var advertDbo = _advertRepository.Get(id);

            if (advertDbo == null)
            {
                throw new ArgumentNullException($"Advert with id {id} not found");
            }

            advertDbo.IsActive = false;
            _advertRepository.Update(advertDbo);
            _dataContext.SaveChanges();
        }
    }
}
