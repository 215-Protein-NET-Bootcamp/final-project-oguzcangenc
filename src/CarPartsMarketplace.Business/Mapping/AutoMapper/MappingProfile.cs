
using AutoMapper;
using CarPartsMarketplace.Entities;
using CarPartsMarketplace.Entities.Dtos;

namespace CarPartsMarketplace.Business.Mapping.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserForRegisterDto, ApplicationUser>().ReverseMap();
            CreateMap<ApplicationUserDto, ApplicationUser>().ReverseMap();

        }


    }
}
