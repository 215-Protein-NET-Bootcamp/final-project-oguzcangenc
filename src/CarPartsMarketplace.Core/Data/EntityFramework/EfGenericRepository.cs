using System.Linq.Expressions;
using CarPartsMarketplace.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarPartsMarketplace.Core.Data.EntityFramework
{
    public abstract class EfGenericRepository<TEntity,TContext> : IEfGenericRepository<TEntity> where TEntity : BaseEntity, IEntity, new() where TContext:DbContext
    {
        protected readonly TContext Context;
        private readonly DbSet<TEntity> _entities;

        public EfGenericRepository(TContext dbContext)
        {
            Context = dbContext;
            _entities = Context.Set<TEntity>();
        }

        public virtual async Task<TEntity?> GetAsync(Expression<Func<TEntity, bool>>? filter = null)
        {
            if (filter != null)
                return await _entities.Where(x => !x.IsDeleted).SingleOrDefaultAsync(filter);

            return await _entities.SingleOrDefaultAsync();
        }

        public virtual async Task<int> TotalRecordAsync()
        {
            return await _entities.CountAsync();
        }

        public virtual async Task<TEntity?> GetByIdAsync(int entityId)
        {
            return await _entities.AsNoTracking().Where(x => !x.IsDeleted).FirstOrDefaultAsync(x => x.Id == entityId);
        }

        public virtual async Task AddAsync(TEntity entity)
        {
            await _entities.AddAsync(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            _entities.Remove(entity);
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>>? filter = null)
        {
            return await (filter == null
                ? _entities.AsNoTracking().Where(x => !x.IsDeleted).ToListAsync()
                : _entities.AsNoTracking().Where(filter).ToListAsync());
        }

        public virtual void Update(TEntity entity)
        {
            _entities.Update(entity);
        }
    }
}
