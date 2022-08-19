using CarPartsMarketplace.Business.Services.Abstract;
using CarPartsMarketplace.Business.Services.Concrete;
using CarPartsMarketplace.Entities.Dtos.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarPartsMarketplace.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _productService.GetAll();
            if (response.Success)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var response = await _productService.Get(id);
            if (response.Success)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

       [Authorize]
        [HttpPost]
        public async Task<IActionResult> Post([FromForm] CreateProductDto createProductDto)
        {
            var response = await _productService.Create(createProductDto);
            if (response.Success)
            {
                return Ok(response);
            }

            return BadRequest(response);
        }
        [Authorize]

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
        [Authorize]

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
