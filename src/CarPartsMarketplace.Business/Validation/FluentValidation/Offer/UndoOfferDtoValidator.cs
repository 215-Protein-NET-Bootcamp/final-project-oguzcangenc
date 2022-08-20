using CarPartsMarketplace.Entities.Dtos.Offer;
using FluentValidation;

namespace CarPartsMarketplace.Business.Validation.FluentValidation.Offer;

public class UndoOfferDtoValidator : AbstractValidator<UndoOfferDto>
{
    public UndoOfferDtoValidator()
    {
        RuleFor(request => request.OfferId).NotEmpty();
    }
}