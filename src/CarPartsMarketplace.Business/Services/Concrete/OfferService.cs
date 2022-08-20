using AutoMapper;
using CarPartsMarketplace.Business.Constant;
using CarPartsMarketplace.Business.Services.Abstract;
using CarPartsMarketplace.Core.Utilities.Results;
using CarPartsMarketplace.Data.Repositories.Abstract;
using CarPartsMarketplace.Data.Repositories.UnitOfWork.Abstract;
using CarPartsMarketplace.Entities;
using CarPartsMarketplace.Entities.Dtos.Offer;
using Microsoft.AspNetCore.Http;

namespace CarPartsMarketplace.Business.Services.Concrete
{
    public class OfferService : GenericService<OfferDto, CreateOfferDto, UpdateOfferDto, Offer>, IOfferService
    {
        private readonly IOfferRepository _offerRepository;
        private readonly IProductService _productService;
        private readonly IUserService _userService;
        public OfferService(IOfferRepository offerRepository,
            IMapper mapper, IUnitOfWork unitOfWork,
            IHttpContextAccessor httpContextAccessor,
            IProductService productService, IUserService userService) : base(offerRepository, mapper, unitOfWork, httpContextAccessor)
        {
            _offerRepository = offerRepository;
            _productService = productService;
            _userService = userService;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<IDataResult<IEnumerable<UserProductOfferDto>>> GetUserOffers()
        {
            var offers = await _offerRepository.GetAllAsync(x => x.UserId == CurrentUserId);


            return new SuccessDataResult<IEnumerable<UserProductOfferDto>>(_mapper.Map<IEnumerable<UserProductOfferDto>>(offers), Messages.RECORD_LISTED);

        }

        public async Task<IDataResult<IEnumerable<UserProductOfferDto>>> GetUserProductOffers()
        {
            var offers = await _offerRepository.GetMyProductOffers(CurrentUserId);


            return new SuccessDataResult<IEnumerable<UserProductOfferDto>>(_mapper.Map<IEnumerable<UserProductOfferDto>>(offers), Messages.RECORD_LISTED);
        }

        public async Task<IResult> UndoOffer(UndoOfferDto undoOfferDto)
        {
            var offer = await _offerRepository.GetAsync(x => x.Id == undoOfferDto.OfferId);
            if (offer == null)
                return new ErrorResult(Messages.RECORD_NOT_FOUND);

            if (offer.UserId != CurrentUserId)
                return new ErrorResult(Messages.UNDO_OFFER_ERROR);

            var productId = offer.ProductId;

            var product = await _productService.Get(productId);

            if (product.Data.IsSold)
                return new ErrorResult(Messages.PRODUCT_IS_SOLD);

            _offerRepository.Delete(offer);
            await _unitOfWork.CompleteAsync();

            return new SuccessResult(Messages.UNDO_OFFER_SUCCESS);
        }

        public override async Task<IResult> Create(CreateOfferDto createResource)
        {
            var product = await _productService.Get(createResource.ProductId);
            if (!product.Success)
                return new ErrorResult(Messages.ID_NOT_EXISTENT);

            if (product.Data.UserId == CurrentUserId)
                return new ErrorResult(Messages.CANNOT_OWN_PRODUCT);

            if (!product.Data.IsOfferable)
                return new ErrorResult(Messages.NO_OFFER);

            if (product.Data.IsSold)
                return new ErrorResult(Messages.PRODUCT_IS_SOLD);

            if (createResource.IsPercentPrice)
            {
                createResource.Price = ((product.Data.Price * createResource.Price) / 100);
            }

            if (createResource.Price > product.Data.Price)
                return new ErrorResult(Messages.OFFER_HIGHER_PRODUCT);

            var offer = await _offerRepository.GetAsync(x => x.ProductId == createResource.ProductId);
            if (offer != null)
                if (offer.UserId == CurrentUserId)
                    return new ErrorResult(Messages.NO_OFFER);


            var result = _mapper.Map<Offer>(createResource);
            result.UserId = CurrentUserId;
            result.CreatedAt = CurrentUserId;
            await _offerRepository.AddAsync(result);
            await _unitOfWork.CompleteAsync();

            return new SuccessDataResult<OfferDto>(_mapper.Map<OfferDto>(result), Messages.RECORD_ADDED);
        }
    }

}
