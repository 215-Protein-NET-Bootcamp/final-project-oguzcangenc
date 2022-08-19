using CarPartsMarketplace.Core.Entities;
using Microsoft.AspNetCore.Http;

namespace CarPartsMarketplace.Entities.Dtos.Product;

public class CreateProductDto : BaseDto
{
    public string Name { get; set; }
    public IFormFile Image { get; set; }
    public int UsageId { get; set; }
    public string Description { get; set; }
    public bool IsOfferable { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public int? BrandId { get; set; }
    public int? ColorId { get; set; }

}