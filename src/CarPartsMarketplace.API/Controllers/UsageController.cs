using CarPartsMarketplace.Business.Services.Abstract;
using CarPartsMarketplace.Entities.Dtos.Usage;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace CarPartsMarketplace.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsageController : ControllerBase
    {
        private readonly IUsageService _usageService
            ;
        public UsageController(IUsageService usageService)
        {
            _usageService = usageService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _usageService.GetAll();
            if (response.Success)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _usageService.Get(id);
            if (result.Success)
            {
                return Ok(result);

            }

            return NotFound(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateUsageDto createUsageDto)
        {
            var result = await _usageService.Create(createUsageDto);
            if (result.Success)
            {
                return Ok(result);

            }

            return BadRequest(result);
        }

        [Authorize]

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateUsageDto updateUsageDto)
        {
            var result = await _usageService.Update(id, updateUsageDto);
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
            var result = await _usageService.Delete(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
