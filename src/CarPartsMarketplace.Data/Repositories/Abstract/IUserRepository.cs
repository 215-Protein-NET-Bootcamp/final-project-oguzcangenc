using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPartsMarketplace.Core.Data;
using CarPartsMarketplace.Entities;

namespace CarPartsMarketplace.Data.Repositories.Abstract
{
    public interface IUserRepository: IEfGenericRepository<ApplicationUser>
    {
    }
}
