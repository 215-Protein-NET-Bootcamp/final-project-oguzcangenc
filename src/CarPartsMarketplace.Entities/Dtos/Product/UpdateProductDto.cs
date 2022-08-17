using CarPartsMarketplace.Core.Entities;

namespace CarPartsMarketplace.Entities.Dtos.Product;

public class UpdateProductDto : BaseDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }

    public virtual int CategoryId { get; set; }
    public virtual int BrandId { get; set; }
    public virtual int ColorId { get; set; }

}