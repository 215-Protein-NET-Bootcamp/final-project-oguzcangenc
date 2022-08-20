using CarPartsMarketplace.Entities.Dtos.Category;
using FluentValidation;

namespace CarPartsMarketplace.Business.Validation.FluentValidation.Category;

public class UpdateCategoryDtoValidator : AbstractValidator<UpdateCategoryDto>
{
    public UpdateCategoryDtoValidator()
    {
        RuleFor(request => request.Name).NotEmpty();
    }
}