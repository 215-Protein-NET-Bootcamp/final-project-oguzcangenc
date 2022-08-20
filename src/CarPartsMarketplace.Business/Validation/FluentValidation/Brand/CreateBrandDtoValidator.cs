using CarPartsMarketplace.Entities.Dtos.Brand;
using FluentValidation;

namespace CarPartsMarketplace.Business.Validation.FluentValidation.Brand;

public class CreateBrandDtoValidator :  AbstractValidator<CreateBrandDto>
{
    public CreateBrandDtoValidator()
    {
        RuleFor(request => request.Name).NotEmpty();
    }
}