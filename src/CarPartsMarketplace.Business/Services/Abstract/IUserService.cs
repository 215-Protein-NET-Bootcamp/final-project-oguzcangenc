using CarPartsMarketplace.Core.Utilities.Results;
using CarPartsMarketplace.Entities;

namespace CarPartsMarketplace.Business.Services.Abstract
{
    public interface IUserService
    {
        Task<IResult> AddAsync(ApplicationUser user);
        IResult Update(ApplicationUser user);
        Task<IDataResult<ApplicationUser>> GetById(int id);
        Task<IDataResult<ApplicationUser>> GetByMail(string mail);
    }
}
