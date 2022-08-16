using CarPartsMarketplace.Core.Data.EntityFramework;
using CarPartsMarketplace.Data.Context.EntityFramework;
using CarPartsMarketplace.Data.Repositories.Abstract;
using CarPartsMarketplace.Entities;

namespace CarPartsMarketplace.Data.Repositories.Concrete;

public class ProductRepository : EfGenericRepository<Product, AppDbContext>, IProductRepository
{
    public ProductRepository(AppDbContext dbContext) : base(dbContext)
    {

    }
}