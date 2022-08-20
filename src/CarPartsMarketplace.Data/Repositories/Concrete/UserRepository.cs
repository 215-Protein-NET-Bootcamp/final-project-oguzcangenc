using System.Linq.Expressions;
using CarPartsMarketplace.Core.Data.EntityFramework;
using CarPartsMarketplace.Core.Entities;
using CarPartsMarketplace.Data.Context.EntityFramework;
using CarPartsMarketplace.Data.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace CarPartsMarketplace.Data.Repositories.Concrete
{
    public class UserRepository : EfGenericRepository<User, AppDbContext>, IUserRepository
    {
        private readonly AppDbContext _dbContext;

        public UserRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public override async Task<User?> GetAsync(Expression<Func<User, bool>>? filter = null)
        {
          return await _dbContext.ApplicationUsers.Where(filter).Include(x=>x.UserOperationClaims).ThenInclude(x=>x.OperationClaim).FirstOrDefaultAsync();
        }
    }
}
