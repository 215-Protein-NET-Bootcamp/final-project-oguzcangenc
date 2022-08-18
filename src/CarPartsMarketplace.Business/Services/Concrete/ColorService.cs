using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using CarPartsMarketplace.Business.Services.Abstract;
using CarPartsMarketplace.Core.Data;
using CarPartsMarketplace.Data.Repositories.Abstract;
using CarPartsMarketplace.Data.Repositories.UnitOfWork.Abstract;
using CarPartsMarketplace.Entities;
using CarPartsMarketplace.Entities.Dtos.Color;

namespace CarPartsMarketplace.Business.Services.Concrete
{
    public class ColorService:GenericService<ColorDto,CreateColorDto,UpdateColorDto,Color>,IColorService
    {
        public ColorService(IColorRepository colorRepository, IMapper mapper, IUnitOfWork unitOfWork) : base(colorRepository, mapper, unitOfWork)
        {
        }
    }
}
