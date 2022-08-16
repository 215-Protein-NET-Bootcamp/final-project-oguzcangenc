using CarPartsMarketplace.Core.Data.EntityFramework;
using CarPartsMarketplace.Data.Context.EntityFramework;
using CarPartsMarketplace.Data.Repositories.Abstract;
using CarPartsMarketplace.Entities;

namespace CarPartsMarketplace.Data.Repositories.Concrete;

public class OfferRepository : EfGenericRepository<Offer, AppDbContext>, IOfferRepository
{
    public OfferRepository(AppDbContext dbContext) : base(dbContext)
    {

    }
}