using CarPartsMarketplace.Business.Services.Abstract;
using CarPartsMarketplace.Entities.Dtos.Brand;
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
        // GET: api/<BrandController>
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

        //// GET api/<BrandController>/5
        //[HttpGet("{id}")]
        //public async Task<IActionResult> Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<BrandController>
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

        //// PUT api/<BrandController>/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<BrandController>/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> Delete(int id)
        //{
        //}
    }
}
