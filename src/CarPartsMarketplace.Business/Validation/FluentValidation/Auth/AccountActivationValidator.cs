using CarPartsMarketplace.Entities.Dtos.ApplicationUser;
using FluentValidation;

namespace CarPartsMarketplace.Business.Validation.FluentValidation.Auth;

public class AccountActivationValidator : AbstractValidator<AccountActivationDto>
{
    public AccountActivationValidator()
    {
       
    }
}