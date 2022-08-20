using CarPartsMarketplace.Core.Utilities.Results;
using CarPartsMarketplace.Entities.Dtos.Product;

namespace CarPartsMarketplace.Business.Services.Abstract
{
    public interface IProductService:IGenericService<ProductDto,CreateProductDto,UpdateProductDto>
    {
        Task<IResult> EditProductImage(int productId, EditProductImageDto editProductImageDto);
    }
}
