using CarPartsMarketplace.Entities.Dtos.ApplicationUser;
using FluentValidation;

namespace CarPartsMarketplace.Business.Validation.FluentValidation.Auth;

public class EmailConfirmationValidator : AbstractValidator<UserEmailConfirmationDto>
{
    public EmailConfirmationValidator()
    {
        RuleFor(request => request.Email).EmailAddress().NotEmpty();
        RuleFor(request => request.EmailHash).NotEmpty();
    }
}