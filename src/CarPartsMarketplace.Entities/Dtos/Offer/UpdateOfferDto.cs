using CarPartsMarketplace.Core.Entities;

namespace CarPartsMarketplace.Entities.Dtos.Offer;

public class UpdateOfferDto : BaseDto
{
    public bool Status { get; set; }
    public bool IsPercentPrice { get; set; }
    public decimal Price { get; set; }
}