using CarPartsMarketplace.Entities;
using CarPartsMarketplace.Entities.Dtos.Category;

namespace CarPartsMarketplace.Business.Services.Abstract
{
    public interface ICategoryService:IGenericService<CategoryDto, CreateCategoryDto,UpdateCategoryDto>
    {
    }
}
