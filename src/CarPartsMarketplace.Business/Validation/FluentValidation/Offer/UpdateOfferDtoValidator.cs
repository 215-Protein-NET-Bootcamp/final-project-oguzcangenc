using CarPartsMarketplace.Entities.Dtos.Offer;
using FluentValidation;

namespace CarPartsMarketplace.Business.Validation.FluentValidation.Offer;

public class UpdateOfferDtoValidator : AbstractValidator<UpdateOfferDto>
{
    public UpdateOfferDtoValidator()
    {
        RuleFor(request => request.Price).NotEmpty();
        RuleFor(request => request.IsPercentPrice).NotEmpty();
        RuleFor(request => request.Status).NotEmpty();
    }
}