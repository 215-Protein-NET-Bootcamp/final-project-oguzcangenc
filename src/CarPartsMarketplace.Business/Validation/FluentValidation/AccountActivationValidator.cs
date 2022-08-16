using CarPartsMarketplace.Entities.Dtos;
using FluentValidation;

namespace CarPartsMarketplace.Business.Validation.FluentValidation;

public class AccountActivationValidator : AbstractValidator<AccountActivationDto>
{
    public AccountActivationValidator()
    {
        RuleFor(request => request.Email).EmailAddress().NotEmpty();
    }
}