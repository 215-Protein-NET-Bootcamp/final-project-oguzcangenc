using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPartsMarketplace.Data.Context.EntityFramework;
using CarPartsMarketplace.Data.Repositories.UnitOfWork.Abstract;

namespace CarPartsMarketplace.Data.Repositories.UnitOfWork.Concrete
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _dbContext;
        public bool Disposed;

        public UnitOfWork(AppDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task CompleteAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
        public void Complete()
        {
            _dbContext.SaveChanges();
        }
        protected virtual void Clean(bool disposing)
        {
            if (!this.Disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            this.Disposed = true;
        }
        public void Dispose()
        {
            Clean(true);
            GC.SuppressFinalize(this);
        }
    }
}
