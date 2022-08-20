using CarPartsMarketplace.Core.Entities;
using CarPartsMarketplace.Core.Utilities.Results;

namespace CarPartsMarketplace.Business.Services.Abstract
{
    public interface IUserService
    {
        Task<IResult> AddAsync(User user);
        IResult Update(User user);
        Task<IDataResult<User>> GetByMail(string mail);
    }
}
