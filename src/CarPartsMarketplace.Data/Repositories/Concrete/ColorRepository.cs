using CarPartsMarketplace.Core.Data.EntityFramework;
using CarPartsMarketplace.Data.Context.EntityFramework;
using CarPartsMarketplace.Data.Repositories.Abstract;
using CarPartsMarketplace.Entities;

namespace CarPartsMarketplace.Data.Repositories.Concrete;

public class ColorRepository : EfGenericRepository<Color, AppDbContext>, IColorRepository
{
    public ColorRepository(AppDbContext dbContext) : base(dbContext)
    {

    }
}