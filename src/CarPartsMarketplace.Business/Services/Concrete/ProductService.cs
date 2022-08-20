using AutoMapper;
using CarPartsMarketplace.Business.Constant;
using CarPartsMarketplace.Business.Services.Abstract;
using CarPartsMarketplace.Business.Validation.FluentValidation.Product;
using CarPartsMarketplace.Core.Aspects.Autofac.Validation;
using CarPartsMarketplace.Core.Utilities.FileHelper.Abstract;
using CarPartsMarketplace.Core.Utilities.Results;
using CarPartsMarketplace.Data.Repositories.Abstract;
using CarPartsMarketplace.Data.Repositories.UnitOfWork.Abstract;
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

        public ProductService(IProductRepository productRepository, IMapper mapper, IUnitOfWork unitOfWork, IFileHelper fileHelper, IHttpContextAccessor httpContextAccessor) : base(productRepository, mapper, unitOfWork, httpContextAccessor)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _fileHelper = fileHelper;
        }

        [ValidationAspect(typeof(ProductCreateValidator))]
        public override async Task<IResult> Create(CreateProductDto createResource)
        {
            try
            {
                var tempEntity = _mapper.Map<CreateProductDto, Product>(createResource);
                var uploadData = await _fileHelper.UploadFileUpdate(createResource.Image);
                if (uploadData.Success)
                {
                    tempEntity.ImageUrl = uploadData.Data;
                    tempEntity.UserId = CurrentUserId;

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

        public override async Task<IResult> Update(int id, UpdateProductDto updateResource)
        {
            try
            {
                var trackEntity = await _productRepository.GetByIdAsync(id);
                if (trackEntity == null)
                    return new ErrorResult(Messages.RECORD_NOT_FOUND);

                if (trackEntity.UserId != CurrentUserId)
                    return new ErrorResult(Messages.UPDATE_AUTH_ERROR);

                var res = _mapper.Map(updateResource, trackEntity);
                _productRepository.Update(trackEntity);
                await _unitOfWork.CompleteAsync();

                return new SuccessResult(Messages.RECORD_UPDATED);
            }
            catch (Exception ex)
            {
                throw new MessageResultException(Messages.UPDATE_ERROR, ex);
            }
        }

        public async Task<IResult> EditProductImage(int productId, EditProductImageDto editProductImageDto)
        {
            var trackEntity = await _productRepository.GetByIdAsync(productId);
            if (trackEntity == null)
                return new ErrorResult(Messages.RECORD_NOT_FOUND);

            if (editProductImageDto.EditFormFile == null)
            {
                trackEntity.ImageUrl = _fileHelper.SetProductImage(trackEntity.ImageUrl);
            }
            else
            {
                var uploadData = await _fileHelper.UploadFileUpdate(editProductImageDto.EditFormFile);
                if (uploadData.Success)
                {
                    trackEntity.ImageUrl = uploadData.Data;
                }
                else
                {
                    return new ErrorResult(Messages.UPDATE_ERROR);

                }
            }

            await _unitOfWork.CompleteAsync();
            return new SuccessResult(Messages.RECORD_UPDATED);
        }
    }

}
