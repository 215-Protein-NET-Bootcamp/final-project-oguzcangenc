using AutoMapper;
using CarPartsMarketplace.Business.Services.Abstract;
using CarPartsMarketplace.Data.Repositories.Abstract;
using CarPartsMarketplace.Data.Repositories.UnitOfWork.Abstract;
using CarPartsMarketplace.Entities;
using CarPartsMarketplace.Entities.Dtos.Usage;
using Microsoft.AspNetCore.Http;

namespace CarPartsMarketplace.Business.Services.Concrete
{
    public class UsageService : GenericService<UsageDto, CreateUsageDto, UpdateUsageDto, Usage>, IUsageService
    {
        public UsageService(IUsageRepository usageRepository, IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(usageRepository, mapper, unitOfWork, httpContextAccessor)
        {
        }

    }
}
