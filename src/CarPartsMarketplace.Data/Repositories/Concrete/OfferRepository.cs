using System.Linq.Expressions;
using CarPartsMarketplace.Core.Data.EntityFramework;
using CarPartsMarketplace.Data.Context.EntityFramework;
using CarPartsMarketplace.Data.Repositories.Abstract;
using CarPartsMarketplace.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarPartsMarketplace.Data.Repositories.Concrete;

public class OfferRepository : EfGenericRepository<Offer, AppDbContext>, IOfferRepository
{
    private readonly AppDbContext _dbContext;

    public OfferRepository(AppDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public override async Task<IEnumerable<Offer>> GetAllAsync(Expression<Func<Offer, bool>>? filter = null)
    {
        var response = await _dbContext.Offers.Where(filter).Include(p => p.Product).ToListAsync();
        return response;
    }

    public async Task<IEnumerable<Offer>> GetMyProductOffers(int userId)
    {
        var userProduct = await _dbContext.Products
            .Where(x => x.IsOfferable == true && x.UserId == userId && x.IsSold == false).Include(x => x.Offers)
            .SelectMany(o => o.Offers).ToListAsync();

        return userProduct;
    }
}