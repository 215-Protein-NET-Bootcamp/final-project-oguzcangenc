using AutoMapper;
using CarPartsMarketplace.Business.Constant;
using CarPartsMarketplace.Business.Services.Abstract;
using CarPartsMarketplace.Core.Entities;
using CarPartsMarketplace.Core.Utilities.FileHelper.Abstract;
using CarPartsMarketplace.Core.Utilities.FileHelper.Concrete;
using CarPartsMarketplace.Core.Utilities.Results;
using CarPartsMarketplace.Data.Repositories.Abstract;
using CarPartsMarketplace.Data.Repositories.UnitOfWork.Abstract;
using CarPartsMarketplace.Data.Repositories.UnitOfWork.Concrete;
using CarPartsMarketplace.Entities;
using CarPartsMarketplace.Entities.Dtos.Product;
using Microsoft.AspNetCore.Http;

namespace CarPartsMarketplace.Business.Services.Concrete
{
    public class ProductService : GenericService<ProductDto, CreateProductDto, UpdateProductDto, Product>, IProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileHelper _fileHelper;

        public ProductService(IProductRepository productRepository, IMapper mapper, IUnitOfWork unitOfWork, IFileHelper fileHelper, IHttpContextAccessor httpContextAccessor) : base(productRepository, mapper, unitOfWork,httpContextAccessor)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _fileHelper = fileHelper;
        }

        public override async Task<IResult> Create(CreateProductDto createResource)
        {
            try
            {
                var tempEntity = _mapper.Map<CreateProductDto, Product>(createResource);
                var uploadData = await _fileHelper.UploadFileUpdate(createResource.Image);
                if (uploadData.Success)
                {
                    tempEntity.ImageUrl = uploadData.Data;
                    tempEntity.ApplicationUserId = CurrentUserId;
              
                }
                await _productRepository.AddAsync(tempEntity);
                await _unitOfWork.CompleteAsync();

                return new SuccessDataResult<ProductDto>(_mapper.Map<Product, ProductDto>(tempEntity), Messages.RECORD_ADDED);
            }
            catch (Exception ex)
            {
                throw new MessageResultException(Messages.ADD_ERROR, ex);
            }
        }

     
    }

}
