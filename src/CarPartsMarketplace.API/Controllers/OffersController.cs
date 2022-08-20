using CarPartsMarketplace.Business.Services.Abstract;
using CarPartsMarketplace.Entities.Dtos.Offer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static CarPartsMarketplace.Entities.Offer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarPartsMarketplace.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OffersController : ControllerBase
    {
        private readonly IOfferService _offerService;
        public OffersController(IOfferService offerService)
        {
            _offerService = offerService;
        }
        [Authorize]
        [HttpGet("user-offers")]
        public async Task<IActionResult> GetUserOffers()
        {
            var response = await _offerService.GetUserOffers();
            if (response.Success)
            {
                return Ok(response);
            }

            return BadRequest(response);

        }
        [Authorize]
        [HttpGet("user-product-offers")]
        public async Task<IActionResult> GeUserProductOffers()
        {
            var response = await _offerService.GetUserProductOffers();
            if (response.Success)
            {
                return Ok(response);
            }

            return BadRequest(response);

        }
        [Authorize]
        [HttpGet("undo-offer")]
        public async Task<IActionResult> UndoOffer([FromQuery] UndoOfferDto offerDto)
        {
            var response = await _offerService.UndoOffer(offerDto);
            if (response.Success)
            {
                return Ok(response);
            }

            return BadRequest(response);

        }
        [Authorize]
        [HttpGet("return-offer")]
        public async Task<IActionResult> ReturnOffer([FromQuery] OfferReturnDto offerReturnDto)
        {
            var response = await _offerService.OfferReturn(offerReturnDto);
            if (response.Success)
            {
                return Ok(response);
            }

            return BadRequest(response);

        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateOfferDto createOfferDto)
        {
            var offer = await _offerService.Create(createOfferDto);
            if (offer.Success)
            {
                return Ok(offer);
            }

            return BadRequest(offer);
        }


        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateOfferDto updateOfferDto)
        {
            var offer = await _offerService.Update(id, updateOfferDto);
            if (offer.Success)
            {
                return Ok(offer);
            }

            return BadRequest(offer);
        }
    }
}
