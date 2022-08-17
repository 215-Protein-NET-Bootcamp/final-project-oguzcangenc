using AutoMapper;
using CarPartsMarketplace.Business.Services.Abstract;
using CarPartsMarketplace.Core.Data;
using CarPartsMarketplace.Data.Repositories.UnitOfWork.Abstract;
using CarPartsMarketplace.Entities.Dtos.Brand;
using CarPartsMarketplace.Entities;
using CarPartsMarketplace.Entities.Dtos.Category;

namespace CarPartsMarketplace.Business.Services.Concrete
{
    public class CategoryService : GenericService<CategoryDto, CreateCategoryDto, UpdateCategoryDto, Category>, ICategoryService
    {
        public CategoryService(IEfGenericRepository<Category> baseRepository, IMapper mapper, IUnitOfWork unitOfWork) : base(baseRepository, mapper, unitOfWork)
        {
        }
    }
}
