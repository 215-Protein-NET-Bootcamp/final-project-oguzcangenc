using CarPartsMarketplace.Business.Services.Abstract;
using CarPartsMarketplace.Core.Utilities.Pagination;
using CarPartsMarketplace.Entities.Dtos.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarPartsMarketplace.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] int pageNumber, [FromQuery] int pageSize)
        {
            var route = Request.Path.Value;
            PaginationFilter pagintation = new PaginationFilter(pageNumber, pageSize);
            var response = await _productService.GetProductPaginationAsync(pagintation,null, route);
            if (response.Success)
            {
                return Ok(response);
            }
            return BadRequest(response);
        }

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
        [HttpGet("category-by-id")]
        public async Task<IActionResult> GetByCategoryId(int id)
        {
            var response = await _productService.GetAllProductDetail(p => p.CategoryId == id);
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


        [HttpPost("edit-product-image")]
        public async Task<IActionResult> EditProductImage(int productId, [FromForm] EditProductImageDto formFile)
        {
            var response = await _productService.EditProductImage(productId,formFile);
            if (response.Success)
            {
                return Ok(response);
            }

            return BadRequest(response);
        }

        [Authorize]
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] UpdateProductDto updateProductDto)
        {
            var result = await _productService.Update(id, updateProductDto);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
