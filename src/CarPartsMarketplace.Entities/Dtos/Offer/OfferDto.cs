using CarPartsMarketplace.Core.Entities;
using CarPartsMarketplace.Entities.Dtos.Product;

namespace CarPartsMarketplace.Entities.Dtos.Offer
{
    public class OfferDto : BaseDto
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public ProductDto ProductDto { get; set; }
        public int ProductId { get; set; }
        public bool Status { get; set; }
        public DateTime Date { get; set; }

    }
}
