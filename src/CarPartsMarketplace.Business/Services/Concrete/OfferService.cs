using AutoMapper;
using CarPartsMarketplace.Business.Services.Abstract;
using CarPartsMarketplace.Data.Repositories.Abstract;
using CarPartsMarketplace.Data.Repositories.UnitOfWork.Abstract;
using CarPartsMarketplace.Entities;
using CarPartsMarketplace.Entities.Dtos.Offer;
using Microsoft.AspNetCore.Http;

namespace CarPartsMarketplace.Business.Services.Concrete
{
    public class OfferService : GenericService<OfferDto, CreateOfferDto, UpdateOfferDto, Offer>, IOfferService
    {
        public OfferService(IOfferRepository offerRepository, IMapper mapper, IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor) : base(offerRepository, mapper, unitOfWork, httpContextAccessor)
        {
        }
    }
   
}
