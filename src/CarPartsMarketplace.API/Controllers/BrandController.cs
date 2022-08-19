using CarPartsMarketplace.Business.Services.Abstract;
using CarPartsMarketplace.Entities.Dtos.Brand;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarPartsMarketplace.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;
        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _brandService.GetAll();
            if (response.Success)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _brandService.Get(id);
            if (result.Success)
            {
                return Ok(result);

            }

            return NotFound(result);
        }
        
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateBrandDto brandDto)
        {
            var result = await _brandService.Create(brandDto);
            if (result.Success)
            {
                return Ok(result);

            }

            return BadRequest(result);
        }

        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateBrandDto updateBrandDto)
        {
            var result = await _brandService.Update(id, updateBrandDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [Authorize]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _brandService.Delete(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
