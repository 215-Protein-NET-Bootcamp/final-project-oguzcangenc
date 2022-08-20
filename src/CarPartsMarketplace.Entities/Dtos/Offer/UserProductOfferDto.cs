using CarPartsMarketplace.Core.Entities;
using CarPartsMarketplace.Entities.Dtos.ApplicationUser;
using CarPartsMarketplace.Entities.Dtos.Product;

namespace CarPartsMarketplace.Entities.Dtos.Offer
{
    public class UserProductOfferDto : BaseDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal Price { get; set; }
        public int ProductId { get; set; }
        public bool Status { get; set; }
        public DateTime Date { get; set; }
    }
}
