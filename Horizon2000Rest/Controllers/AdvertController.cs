using AutoMapper;
using Horizon2000Rest.Core.Interfaces;
using Horizon2000Rest.Core.Models.Advert;
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

        /// <summary>
        /// Adds a new advert.
        /// </summary>
        /// <param name="add">The AddAdvertDto object containing the details of the advert to add.</param>
        /// <returns>The IActionResult indicating the result of the operation.</returns>
        [HttpPost]
        public IActionResult AddAdvert([FromBody] AddAdvertDto add)
        {
            if (add == null)
                return BadRequest("Advert is null");

            var id = _advertWorker.AddAdvert(add);

            return Ok($"Successfully created advert with ID: {id}");
        }

        /// <summary>
        /// Deactivates an advert by ID.
        /// </summary>
        /// <param name="id">The ID of the advert to deactivate.</param>
        /// <returns>The IActionResult indicating the result of the operation.</returns>
        [HttpPut("{id}")]
        public IActionResult DeactivateAdvert(int id)
        {
            _advertWorker.DeactivateAdvert(id);

            return Ok($"Successfully deactivated advert with ID: {id}");
        }
    }
}
