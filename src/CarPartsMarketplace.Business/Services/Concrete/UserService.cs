using CarPartsMarketplace.Business.Constant;
using CarPartsMarketplace.Business.Services.Abstract;
using CarPartsMarketplace.Core.Entities;
using CarPartsMarketplace.Core.Utilities.Results;
using CarPartsMarketplace.Data.Repositories.Abstract;
using CarPartsMarketplace.Data.Repositories.UnitOfWork.Abstract;

namespace CarPartsMarketplace.Business.Services.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;
        public UserService(IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<IResult> AddAsync(User user)
        {
            await _userRepository.AddAsync(user);
            await _unitOfWork.CompleteAsync();
            return new SuccessResult(Messages.ADD_APPLICATON_USER);

        }
        public async Task<IResult> Delete(User user)
        {
            _userRepository.Delete(user);
            await _unitOfWork.CompleteAsync();

            return new SuccessResult(Messages.DELETE_APPLICATION_USER);
        }
        public async Task<IDataResult<User>> GetById(int id)
        {
            var response = await _userRepository.GetByIdAsync(id);
            if (response == null)
            {
                return new ErrorDataResult<User>();
            }
            return new SuccessDataResult<User>(response, Messages.GET_APPLICATION_USER);
        }
        public async Task<IDataResult<User>> GetByMail(string mail)
        {
            var response = await _userRepository.GetAsync(user => user.Email == mail);
            if (response == null)
            {
                return new ErrorDataResult<User>();
            }
            return new SuccessDataResult<User>(response);
        }
        public async Task<IDataResult<User>> GetByMailAndUsername(string mail, string username)
        {
            var response = await _userRepository.GetAsync(user => user.Email == mail);
            if (response == null)
            {
                return new ErrorDataResult<User>();
            }
            return new SuccessDataResult<User>();
        }
        public IResult Update(User user)
        {
            _userRepository.Update(user);
            return new SuccessDataResult<User>(user);
        }
    }
}
