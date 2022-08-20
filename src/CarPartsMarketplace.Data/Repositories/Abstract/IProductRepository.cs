using CarPartsMarketplace.Core.Data;
using CarPartsMarketplace.Core.Entities;
using CarPartsMarketplace.Entities;
using System.Linq.Expressions;

namespace CarPartsMarketplace.Data.Repositories.Abstract
{
    public interface IProductRepository : IEfGenericRepository<Product>
    {
        Task<IEnumerable<Product>> GetAllByCategoryIdAsync(int categoryId);
    }

}
