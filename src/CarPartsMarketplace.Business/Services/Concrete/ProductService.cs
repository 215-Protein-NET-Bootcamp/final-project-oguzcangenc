using AutoMapper;
using CarPartsMarketplace.Business.Adapters.RedisService;
using CarPartsMarketplace.Business.Constant;
using CarPartsMarketplace.Business.Services.Abstract;
using CarPartsMarketplace.Business.Validation.FluentValidation.Product;
using CarPartsMarketplace.Core.Aspects.Autofac.Validation;
using CarPartsMarketplace.Core.Extensions;
using CarPartsMarketplace.Core.Utilities.FileHelper.Abstract;
using CarPartsMarketplace.Core.Utilities.Pagination;
using CarPartsMarketplace.Core.Utilities.Results;
using CarPartsMarketplace.Data.Repositories.Abstract;
using CarPartsMarketplace.Data.Repositories.UnitOfWork.Abstract;
using CarPartsMarketplace.Entities;
using CarPartsMarketplace.Entities.Dtos.Product;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using StackExchange.Redis;
using System;
using System.Linq.Expressions;
using System.Text;

namespace CarPartsMarketplace.Business.Services.Concrete
{
    public class ProductService : GenericService<ProductDto, CreateProductDto, UpdateProductDto, Product>, IProductService
    {
        private readonly IMapper _mapper;
        private readonly IRelatePaginationUri _relatePaginationUri;
        private readonly IRedisClearCache _redisClearCache;
        private readonly IProductRepository _productRepository;
        private readonly IDistributedCache _distributedCache;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IFileHelper _fileHelper;

        public ProductService(IProductRepository productRepository,
            IMapper mapper,
            IUnitOfWork unitOfWork,
            IFileHelper fileHelper,
            IHttpContextAccessor httpContextAccessor,
            IDistributedCache distributedCache,
            IRelatePaginationUri relatePaginationUri,
            IRedisClearCache redisClearCache) : base(productRepository, mapper, unitOfWork, httpContextAccessor)
        {
            _productRepository = productRepository;
            _distributedCache = distributedCache;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _fileHelper = fileHelper;
            _relatePaginationUri = relatePaginationUri;
            _redisClearCache = redisClearCache;
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
                _redisClearCache.RedisCacheClear();

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
                _redisClearCache.RedisCacheClear();

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
        public async Task<IDataResult<IEnumerable<ProductDto>>> GetByCategoryId(int categoryId)
        {
            var categoryProduct = await _productRepository.GetAllByCategoryIdAsync(categoryId);
            if (categoryProduct == null)
                return new ErrorDataResult<IEnumerable<ProductDto>>(Messages.ID_NOT_EXISTENT);

            return new SuccessDataResult<IEnumerable<ProductDto>>(_mapper.Map<IEnumerable<ProductDto>>(categoryProduct), Messages.RECORD_LISTED);
        }
        public async Task<IResult> SellOfferProduct(int productId, int buyUserId)
        {
            var product = await _productRepository.GetAsync(x => x.Id == productId);
            if (product.IsSold)
                return new ErrorResult(Messages.PRODUCT_IS_SOLD);
            if (product == null)
                return new ErrorResult(Messages.UPDATE_ERROR);
            product.IsSold = true;
            product.IsOfferable = false;
            product.PurchasingUserId = buyUserId;
            await _unitOfWork.CompleteAsync();

            return new SuccessResult(Messages.RECORD_UPDATED);
        }
        public async Task<IDataResult<IEnumerable<ProductDto>>> GetAllProductDetail(Expression<Func<Product, bool>>? filter = null)
        {
            var detailProducts = await _productRepository.GetAllDetailProductAsync(filter);
            if (detailProducts == null)
                return new ErrorDataResult<IEnumerable<ProductDto>>(Messages.RECORD_NOT_FOUND);

            return new SuccessDataResult<IEnumerable<ProductDto>>(_mapper.Map<IEnumerable<ProductDto>>(detailProducts), Messages.RECORD_LISTED);
        }
        public async Task<IDataResult<IEnumerable<ProductDto>>> GetProductPaginationAsync(PaginationFilter paginationFilter, ProductDto filterResource, string route)
        {
            var cacheKey = $"product-{paginationFilter.PageNumber}-{paginationFilter.PageSize}";
            string json;
            var productFromCache = await _distributedCache.GetAsync(cacheKey);
            if (productFromCache != null)
            {
                json = Encoding.UTF8.GetString(productFromCache);
                var products = JsonConvert.DeserializeObject<PaginationEntityResponse<ProductDto>>(json);
                return new PaginatedResult<IEnumerable<ProductDto>>(products.Data, products.PageNumber, products.PageSize)
                {
                    PreviousPage = products.PreviousPage,
                    NextPage = products.NextPage,
                    LastPage = products.LastPage,
                    FirstPage = products.FirstPage,
                    TotalPages = products.TotalPages,
                    TotalRecords = products.TotalRecords
                };
            }
            else
            {
                var paginationPerson = await _productRepository.GetProductPaginationAsync(paginationFilter, filterResource);
                var resource = GeneratePagination(paginationFilter, route, paginationPerson);
                json = JsonConvert.SerializeObject(resource);
                productFromCache = Encoding.UTF8.GetBytes(json);
                var options = new DistributedCacheEntryOptions()
                        .SetSlidingExpiration(TimeSpan.FromDays(1))
                        .SetAbsoluteExpiration(DateTime.Now.AddMonths(1));
                await _distributedCache.SetAsync(cacheKey, productFromCache, options);
                return resource;
            }
        }
        private PaginatedResult<IEnumerable<ProductDto>> GeneratePagination(PaginationFilter paginationFilter, string route, (IEnumerable<Product> records, int total) paginationPerson)
        {
            var tempResource = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductDto>>(paginationPerson.records);
            var resource = new PaginatedResult<IEnumerable<ProductDto>>(tempResource);
            resource.CreatePaginationResponse(paginationFilter, paginationPerson.total, _relatePaginationUri, route);
            return resource;
        }

        public async Task<IResult> SellDirectProduct(int productId)
        {
            var product = await _productRepository.GetAsync(x => x.Id == productId);

            if (product.UserId == CurrentUserId)
                return new ErrorResult(Messages.CANNOT_SELL_OWN_PRODUCT);
            
            if (product.IsSold)
                return new ErrorResult(Messages.PRODUCT_IS_SOLD);
            
            if (product == null)
                return new ErrorResult(Messages.UPDATE_ERROR);
            
            product.IsSold = true;
            product.IsOfferable = false;
            product.PurchasingUserId = CurrentUserId;
            await _unitOfWork.CompleteAsync();

            return new SuccessResult(Messages.RECORD_UPDATED);
        }
    }

}
