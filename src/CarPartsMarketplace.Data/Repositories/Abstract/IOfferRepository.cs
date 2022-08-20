using CarPartsMarketplace.Core.Data;
using CarPartsMarketplace.Entities;

namespace CarPartsMarketplace.Data.Repositories.Abstract;
public interface IOfferRepository : IEfGenericRepository<Offer>
{
    Task<IEnumerable<Offer>> GetMyProductOffers(int userId);

}