using CarPartsMarketplace.Core.Entities;

namespace CarPartsMarketplace.Entities
{
    public class Offer : BaseEntity
    {
        public enum OfferReturnType
        {
            Reject,
            Accept
        }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public bool Status { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public OfferReturnType OfferReturn { get; set; }
        public virtual Product Product { get; set; }
    }
}
