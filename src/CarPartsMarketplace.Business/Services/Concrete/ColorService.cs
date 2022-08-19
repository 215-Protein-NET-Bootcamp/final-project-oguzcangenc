using AutoMapper;
using CarPartsMarketplace.Business.Services.Abstract;
using CarPartsMarketplace.Data.Repositories.Abstract;
using CarPartsMarketplace.Data.Repositories.UnitOfWork.Abstract;
using CarPartsMarketplace.Entities;
using CarPartsMarketplace.Entities.Dtos.Color;
using Microsoft.AspNetCore.Http;

namespace CarPartsMarketplace.Business.Services.Concrete
{
    public class ColorService:GenericService<ColorDto,CreateColorDto,UpdateColorDto,Color>,IColorService
    {
        public ColorService(IColorRepository colorRepository, IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(colorRepository, mapper, unitOfWork, httpContextAccessor)
        {
        }
     
    }
}
