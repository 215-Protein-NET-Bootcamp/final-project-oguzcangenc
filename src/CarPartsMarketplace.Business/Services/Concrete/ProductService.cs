using AutoMapper;
using CarPartsMarketplace.Business.Services.Abstract;
using CarPartsMarketplace.Core.Data;
using CarPartsMarketplace.Data.Repositories.UnitOfWork.Abstract;
using CarPartsMarketplace.Entities;
using CarPartsMarketplace.Entities.Dtos.Product;

namespace CarPartsMarketplace.Business.Services.Concrete
{
    public class ProductService : GenericService<ProductDto, CreateProductDto, UpdateProductDto, Product>, IProductService
    {
        public ProductService(IEfGenericRepository<Product> baseRepository, IMapper mapper, IUnitOfWork unitOfWork) : base(baseRepository, mapper, unitOfWork)
        {
        }
    }

}
