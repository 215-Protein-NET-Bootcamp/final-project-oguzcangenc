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
        public int UserId { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public bool IsOfferable { get; set; }
        public decimal Price { get; set; }
        public bool IsSold { get; set; }
        public int PurchasingUserId { get; set; }
        public  UserDto User { get; set; }
        public  CategoryDto Category { get; set; }
        public  BrandDto Brand { get; set; }
        public  ColorDto Color { get; set; }
        public  UsageDto Usage { get; set; }
    }
}
