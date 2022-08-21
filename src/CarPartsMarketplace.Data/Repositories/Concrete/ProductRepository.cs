using System.Linq.Expressions;
using CarPartsMarketplace.Core.Data.EntityFramework;
using CarPartsMarketplace.Core.Extensions;
using CarPartsMarketplace.Core.Utilities.Pagination;
using CarPartsMarketplace.Data.Context.EntityFramework;
using CarPartsMarketplace.Data.Repositories.Abstract;
using CarPartsMarketplace.Entities;
using CarPartsMarketplace.Entities.Dtos.Product;
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
    public async Task<IEnumerable<Product>> GetAllDetailProductAsync(Expression<Func<Product, bool>>? filter = null)
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
    public async Task<(IEnumerable<Product> records, int total)> GetProductPaginationAsync(PaginationFilter paginationFilter, ProductDto filterResource)
    {
        var queryable = ConditionFilter(filterResource);

        var total = await queryable.CountAsync();

        var records = await queryable.AsNoTracking()
            .AsSplitQuery()
            .OrderBy(x => x.Id)
            .Skip((paginationFilter.PageNumber - 1) * paginationFilter.PageSize)
            .Take(paginationFilter.PageSize)
            .ToListAsync();

        return (records, total);
    }
    private IQueryable<Product> ConditionFilter(ProductDto filterResource)
    {
        var queryable = _dbContext.Products.AsQueryable();
        
        if (filterResource != null)
        {

            if (!string.IsNullOrEmpty(filterResource.Name))
            {
                string fullName = filterResource.Name.RemoveSpaceCharacter().ToLower();
                queryable = queryable.Where(x => x.Name.Contains(fullName));
            }
        }

        return queryable;
    }
}