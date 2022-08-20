
using AutoMapper;
using CarPartsMarketplace.Core.Entities;
using CarPartsMarketplace.Entities;
using CarPartsMarketplace.Entities.Dtos.ApplicationUser;
using CarPartsMarketplace.Entities.Dtos.Brand;
using CarPartsMarketplace.Entities.Dtos.Category;
using CarPartsMarketplace.Entities.Dtos.Color;
using CarPartsMarketplace.Entities.Dtos.Offer;
using CarPartsMarketplace.Entities.Dtos.Product;
using CarPartsMarketplace.Entities.Dtos.Usage;

namespace CarPartsMarketplace.Business.Mapping.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserForRegisterDto, User>().ReverseMap();
            CreateMap<UserDto, User>().ReverseMap();

            CreateMap<ProductDto, Product>().ReverseMap();
            CreateMap<CreateProductDto, Product>().ReverseMap();
            CreateMap<UpdateProductDto, Product>().ReverseMap();


            CreateMap<BrandDto, Brand>().ReverseMap();
            CreateMap<CreateBrandDto, Brand>().ReverseMap();
            CreateMap<UpdateBrandDto, Brand>().ReverseMap();


            CreateMap<ColorDto, Color>().ReverseMap();
            CreateMap<CreateColorDto, Color>().ReverseMap();
            CreateMap<UpdateColorDto, Color>().ReverseMap();

            CreateMap<CategoryDto, Category>().ReverseMap();
            CreateMap<CreateCategoryDto, Category>().ReverseMap();
            CreateMap<UpdateCategoryDto, Category>().ReverseMap();

            CreateMap<OfferDto, Offer>().ReverseMap();
            CreateMap<CreateOfferDto, Offer>().ReverseMap();
            CreateMap<UpdateOfferDto, Offer>().ReverseMap();

            CreateMap<UsageDto, Usage>().ReverseMap();
            CreateMap<CreateUsageDto, Usage>().ReverseMap();
            CreateMap<UpdateUsageDto, Usage>().ReverseMap();


        }


    }
}
