using CarPartsMarketplace.Entities.Dtos.Brand;
using CarPartsMarketplace.Entities.Dtos.Color;
using FluentValidation;

namespace CarPartsMarketplace.Business.Validation.FluentValidation.Category;

public class CreateColorDtoValidator : AbstractValidator<CreateColorDto>
{
    public CreateColorDtoValidator()
    {
        RuleFor(request => request.Name).NotEmpty();
    }
}