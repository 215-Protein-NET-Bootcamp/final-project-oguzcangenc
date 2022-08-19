using CarPartsMarketplace.Core.Data.EntityFramework;
using CarPartsMarketplace.Data.Context.EntityFramework;
using CarPartsMarketplace.Data.Repositories.Abstract;
using CarPartsMarketplace.Entities;

namespace CarPartsMarketplace.Data.Repositories.Concrete
{
    public class UsageRepository : EfGenericRepository<Usage, AppDbContext>, IUsageRepository
    {
        public UsageRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}



