using CarPartsMarketplace.Core.Entities;

namespace CarPartsMarketplace.Entities.Dtos.Offer;

public class CreateOfferDto : BaseDto
{
    public decimal Price { get; set; }
    public int ProductId { get; set; }

}