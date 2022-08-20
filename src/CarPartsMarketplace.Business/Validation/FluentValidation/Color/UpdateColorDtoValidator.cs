using CarPartsMarketplace.Entities.Dtos.Brand;
using CarPartsMarketplace.Entities.Dtos.Color;
using FluentValidation;

namespace CarPartsMarketplace.Business.Validation.FluentValidation.Category;

public class UpdateColorDtoValidator : AbstractValidator<UpdateColorDto>
{
    public UpdateColorDtoValidator()
    {
        RuleFor(request => request.Name).NotEmpty();
    }
}