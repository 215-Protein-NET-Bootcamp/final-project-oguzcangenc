using CarPartsMarketplace.Entities.Dtos.ApplicationUser;
using FluentValidation;

namespace CarPartsMarketplace.Business.Validation.FluentValidation;

public class UserForLoginDtoValidator : AbstractValidator<UserLoginDto>
{
    public UserForLoginDtoValidator()
    {
        RuleFor(request => request.Email).EmailAddress().NotEmpty();
        RuleFor(request => request.Password).NotEmpty();
    }
}