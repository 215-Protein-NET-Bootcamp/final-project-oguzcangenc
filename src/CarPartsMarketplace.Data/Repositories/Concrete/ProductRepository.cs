using System.Linq.Expressions;
using CarPartsMarketplace.Core.Data.EntityFramework;
using CarPartsMarketplace.Data.Context.EntityFramework;
using CarPartsMarketplace.Data.Repositories.Abstract;
using CarPartsMarketplace.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarPartsMarketplace.Data.Repositories.Concrete;

public class ProductRepository : EfGenericRepository<Product, AppDbContext>, IProductRepository
{
    private readonly AppDbContext _dbContext;
    public ProductRepository(AppDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public override async Task<Product?> GetAsync(Expression<Func<Product, bool>> filter = null)
    {

        var product = await _dbContext.Products
            .Where(filter)
            .AsSplitQuery()
            .Include(x => x.Brand)
            .Include(x => x.Category)
            .Include(x => x.Color)
            .Include(x => x.Usage)
            .Include(x => x.User)
            .FirstOrDefaultAsync();
        return product;


    }

    public async Task<IEnumerable<Product>> GetAllByCategoryIdAsync(int categoryId)
    {
        return await _dbContext.Products.Where(x => x.CategoryId == categoryId).AsNoTracking().ToListAsync();
    }

    public override async Task<IEnumerable<Product>> GetAllAsync(Expression<Func<Product, bool>>? filter = null)
    {
        var product = await _dbContext.Products
            .Include(x => x.Brand)
            .Include(x => x.Category)
            .Include(x => x.Color)
            .Include(x => x.Usage)
            .Include(x => x.User)
            .ToListAsync();

        return product;
    }
}