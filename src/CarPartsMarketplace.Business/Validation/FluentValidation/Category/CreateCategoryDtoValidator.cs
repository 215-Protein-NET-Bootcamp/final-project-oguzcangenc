using CarPartsMarketplace.Entities.Dtos.Category;
using FluentValidation;

namespace CarPartsMarketplace.Business.Validation.FluentValidation.Category;

public class CreateCategoryDtoValidator : AbstractValidator<CreateCategoryDto>
{
    public CreateCategoryDtoValidator()
    {
        RuleFor(request => request.Name).NotEmpty();
    }
}