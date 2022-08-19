using AutoMapper;
using CarPartsMarketplace.Business.Services.Abstract;
using CarPartsMarketplace.Data.Repositories.Abstract;
using CarPartsMarketplace.Data.Repositories.UnitOfWork.Abstract;
using CarPartsMarketplace.Entities;
using CarPartsMarketplace.Entities.Dtos.Brand;
using Microsoft.AspNetCore.Http;

namespace CarPartsMarketplace.Business.Services.Concrete
{
    public class BrandService:GenericService<BrandDto,CreateBrandDto,UpdateBrandDto,Brand>,IBrandService
    {
        public BrandService(IBrandRepository brandRepository, IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(brandRepository, mapper, unitOfWork, httpContextAccessor)
        {
        }
       
    }
}
