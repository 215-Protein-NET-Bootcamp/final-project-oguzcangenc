using CarPartsMarketplace.Core.Entities;

namespace CarPartsMarketplace.Entities.Dtos.Offer;

public class UpdateOfferDto : BaseDto
{
    public int ProductId { get; set; }
    public decimal Price { get; set; }

}