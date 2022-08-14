using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPartsMarketplace.Core.Data.EntityFramework;
using CarPartsMarketplace.Data.Context.EntityFramework;
using CarPartsMarketplace.Data.Repositories.Abstract;
using CarPartsMarketplace.Entities;

namespace CarPartsMarketplace.Data.Repositories.Concrete
{
    public class UserRepository:EfGenericRepository<ApplicationUser,AppDbContext>,IUserRepository
    {
        public UserRepository(AppDbContext dbContext) : base(dbContext)
        {
            
        }
    }
}
