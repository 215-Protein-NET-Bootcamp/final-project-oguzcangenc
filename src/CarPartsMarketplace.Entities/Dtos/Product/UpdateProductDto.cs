using CarPartsMarketplace.Core.Entities;

namespace CarPartsMarketplace.Entities.Dtos.Product;

public class UpdateProductDto : BaseDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public  int CategoryId { get; set; }
    public  int BrandId { get; set; }
    public  int ColorId { get; set; }

}