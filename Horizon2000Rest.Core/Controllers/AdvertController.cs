using AutoMapper;
using Horizon2000Rest.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Horizon2000Rest.Controllers
{
    /// <summary>
    /// Controller for managing adverts.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IAdvertWorker _advertWorker;

        /// <summary>
        /// Initializes a new instance of the AdvertController class.
        /// </summary>
        /// <param name="mapper">The IMapper instance for object mapping.</param>
        /// <param name="advertWorker">The IAdvertWorker instance for advert operations.</param>
        public AdvertController(IMapper mapper, IAdvertWorker advertWorker)
        {
            _mapper = mapper;
            _advertWorker = advertWorker;
        }

        /// <summary>
        /// Retrieves an advert by ID.
        /// </summary>
        /// <param name="id">The ID of the advert to retrieve.</param>
        /// <returns>The ActionResult containing the advert details if found, or BadRequest with an appropriate message if not found.</returns>
        [HttpGet("{id}")]
        public IActionResult GetAdvert(int id)
        {
            var advertDto = _advertWorker.GetAdvert(id);
            return advertDto is { } 
                ? Ok(advertDto)
                : BadRequest("Advert not found");
        }
    }
}
