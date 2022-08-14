using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CarPartsMarketplace.Core.Entities;

namespace CarPartsMarketplace.Core.Data
{
    public interface IEfGenericRepository<TEntity> where TEntity:BaseEntity,IEntity,new()
    {
        Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? filter = null);
        Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>>? filter = null);
        Task<TEntity?> GetByIdAsync(int entityId);
        Task AddAsync(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
