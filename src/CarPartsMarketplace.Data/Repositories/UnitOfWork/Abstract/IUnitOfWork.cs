using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPartsMarketplace.Data.Repositories.UnitOfWork.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        Task CompleteAsync();
        void Complete();
    }
}
