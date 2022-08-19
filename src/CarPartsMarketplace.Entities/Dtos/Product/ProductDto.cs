using CarPartsMarketplace.Core.Entities;
using CarPartsMarketplace.Entities.Dtos.ApplicationUser;
using CarPartsMarketplace.Entities.Dtos.Brand;
using CarPartsMarketplace.Entities.Dtos.Category;
using CarPartsMarketplace.Entities.Dtos.Color;
using CarPartsMarketplace.Entities.Dtos.Usage;

namespace CarPartsMarketplace.Entities.Dtos.Product
{
    public class ProductDto : BaseDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ApplicationUserId { get; set; }
        public Uri ImageUrl { get; set; }
        public string Description { get; set; }
        public bool IsOfferable { get; set; }
        public decimal Price { get; set; }
        public bool IsSold { get; set; }

        public  ApplicationUserDto ApplicationUser { get; set; }
        public  CategoryDto Category { get; set; }
        public  BrandDto Brand { get; set; }
        public  ColorDto Color { get; set; }
        public  UsageDto Usage { get; set; }
    }
}
