using CarPartsMarketplace.Core.Data;
using CarPartsMarketplace.Core.Entities;
using CarPartsMarketplace.Core.Utilities.Pagination;
using CarPartsMarketplace.Entities;
using CarPartsMarketplace.Entities.Dtos.Product;
using System.Linq.Expressions;

namespace CarPartsMarketplace.Data.Repositories.Abstract
{
    public interface IProductRepository : IEfGenericRepository<Product>
    {
        Task<IEnumerable<Product>> GetAllByCategoryIdAsync(int categoryId);
        Task<IEnumerable<Product>> GetAllDetailProductAsync(Expression<Func<Product, bool>>? filter = null);
        Task<(IEnumerable<Product> records, int total)> GetProductPaginationAsync(PaginationFilter paginationFilter, ProductDto filterResource);
    }

}
