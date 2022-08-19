using System.Linq.Expressions;
using CarPartsMarketplace.Core.Data.EntityFramework;
using CarPartsMarketplace.Data.Context.EntityFramework;
using CarPartsMarketplace.Data.Repositories.Abstract;
using CarPartsMarketplace.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarPartsMarketplace.Data.Repositories.Concrete
{
    public class UserRepository : EfGenericRepository<ApplicationUser, AppDbContext>, IUserRepository
    {
        private readonly AppDbContext _dbContext;

        public UserRepository(AppDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public override async Task<ApplicationUser?> GetAsync(Expression<Func<ApplicationUser, bool>>? filter = null)
        {
          return await _dbContext.ApplicationUsers.Where(filter).Include(x=>x.UserOperationClaims).ThenInclude(x=>x.OperationClaim).FirstOrDefaultAsync();
        }
    }
}
