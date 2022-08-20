using CarPartsMarketplace.Core.Utilities.Results;
using CarPartsMarketplace.Entities.Dtos.Offer;
using CarPartsMarketplace.Entities.Dtos.Product;

namespace CarPartsMarketplace.Business.Services.Abstract
{
    public interface IOfferService : IGenericService<OfferDto, CreateOfferDto, UpdateOfferDto>
    {
        Task<IDataResult<IEnumerable<UserProductOfferDto>>> GetUserOffers();

        Task<IDataResult<IEnumerable<UserProductOfferDto>>> GetUserProductOffers();
        Task<IResult> UndoOffer(UndoOfferDto undoOfferDto);

    }

}
