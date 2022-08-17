using CarPartsMarketplace.Core.Data.EntityFramework;
using CarPartsMarketplace.Data.Context.EntityFramework;
using CarPartsMarketplace.Data.Repositories.Abstract;
using CarPartsMarketplace.Entities;

namespace CarPartsMarketplace.Data.Repositories.Concrete
{
    public class BrandRepository : EfGenericRepository<Brand, AppDbContext>, IBrandRepository
    {
        public BrandRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }

}
