using CarPartsMarketplace.Entities.Dtos.Brand;
using FluentValidation;

namespace CarPartsMarketplace.Business.Validation.FluentValidation.Brand;

public class UpdateBrandDtoValidator : AbstractValidator<UpdateBrandDto>
{
    public UpdateBrandDtoValidator()
    {
        RuleFor(request => request.Name).NotEmpty();
    }
}