using CarPartsMarketplace.Core.Utilities.Pagination;
using CarPartsMarketplace.Core.Utilities.Results;
using CarPartsMarketplace.Entities;
using CarPartsMarketplace.Entities.Dtos.Product;
using System.Linq.Expressions;

namespace CarPartsMarketplace.Business.Services.Abstract
{
    public interface IProductService : IGenericService<ProductDto, CreateProductDto, UpdateProductDto>
    {
        Task<IResult> EditProductImage(int productId, EditProductImageDto editProductImageDto);
        Task<IDataResult<IEnumerable<ProductDto>>> GetByCategoryId(int categoryId);
        Task<IDataResult<IEnumerable<ProductDto>>> GetAllProductDetail(Expression<Func<Product, bool>>? filter = null);
        Task<IDataResult<IEnumerable<ProductDto>>> GetProductPaginationAsync(PaginationFilter paginationFilter, ProductDto filterResource, string route);
        Task<IResult> SellOfferProduct(int productId, int buyUserId);
        Task<IResult> SellDirectProduct(int productId);

    }
}
