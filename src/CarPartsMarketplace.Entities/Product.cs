using CarPartsMarketplace.Core.Entities;

namespace CarPartsMarketplace.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int? BrandId { get; set; }
        public decimal Price { get; set; }
        public int? ColorId { get; set; }
        public int UsageId { get; set; }
        public int CategoryId { get; set; }
        public bool IsOfferable { get; set; }
        public bool IsSold { get; set; }
        public int UserId { get; set; }
        public int PurchasingUserId { get; set; }

        public virtual Usage Usage { get; set; }
        public virtual Category Category { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual Color Color { get; set; }
        public virtual ICollection<Offer> Offers { get; set; }
        public virtual User User { get; set; }

    }
}
