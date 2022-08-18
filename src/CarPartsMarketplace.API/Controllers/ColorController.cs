using CarPartsMarketplace.Business.Services.Abstract;
using CarPartsMarketplace.Entities.Dtos.Color;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarPartsMarketplace.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorController : ControllerBase
    {
        // GET: api/<CategoryController>
        private readonly IColorService _colorService
            ;
        public ColorController(IColorService colorService)
        {
            _colorService = colorService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _colorService.GetAll();
            if (response.Success)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _colorService.Get(id);
            if (result.Success)
            {
                return Ok(result);

            }

            return NotFound(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateColorDto brandDto)
        {
            var result = await _colorService.Create(brandDto);
            if (result.Success)
            {
                return Ok(result);

            }

            return BadRequest(result);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateColorDto updateColorDto)
        {
            var result = await _colorService.Update(id, updateColorDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _colorService.Delete(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
