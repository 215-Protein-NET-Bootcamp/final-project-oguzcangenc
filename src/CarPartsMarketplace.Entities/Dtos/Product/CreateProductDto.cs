using CarPartsMarketplace.Core.Entities;

namespace CarPartsMarketplace.Entities.Dtos.Product;

public class CreateProductDto : BaseDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string ImageUrl { get; set; }
    public string Description { get; set; }
    public bool IsOfferable { get; set; } //bu alan default false olacak.
    public decimal Price { get; set; }
    public bool IsSold { get; set; } // Bu alan default false olacak.

    public virtual int CategoryId { get; set; }
    public virtual int BrandId { get; set; }
    public virtual int ColorId { get; set; }

}