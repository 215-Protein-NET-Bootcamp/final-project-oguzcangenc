using CarPartsMarketplace.Core.Entities;

namespace CarPartsMarketplace.Entities.Dtos.Offer
{
    public class OfferDto : BaseDto
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public Entities.Product Product { get; set; }
        public Entities.Color? Color { get; set; }
        public Entities.Brand Brand { get; set; }
        public Entities.Category Category { get; set; }
    }
}
