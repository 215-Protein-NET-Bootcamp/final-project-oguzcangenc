using CarPartsMarketplace.Entities.Dtos.Offer;
using FluentValidation;

namespace CarPartsMarketplace.Business.Validation.FluentValidation.Offer;

public class OfferReturnDtoValidator : AbstractValidator<OfferReturnDto>
{
    public OfferReturnDtoValidator()
    {
        RuleFor(request => request.OfferId).NotEmpty();
    }
}