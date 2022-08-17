using CarPartsMarketplace.Entities.Dtos.ApplicationUser;
using FluentValidation;

namespace CarPartsMarketplace.Business.Validation.FluentValidation;

public class AccountActivationValidator : AbstractValidator<AccountActivationDto>
{
    public AccountActivationValidator()
    {
        RuleFor(request => request.Email).EmailAddress().NotEmpty();
    }
}