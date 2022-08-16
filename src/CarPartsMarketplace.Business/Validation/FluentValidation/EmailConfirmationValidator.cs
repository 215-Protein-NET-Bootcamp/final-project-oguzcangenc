using CarPartsMarketplace.Entities.Dtos;
using FluentValidation;

namespace CarPartsMarketplace.Business.Validation.FluentValidation;

public class EmailConfirmationValidator : AbstractValidator<UserEmailConfirmationDto>
{
    public EmailConfirmationValidator()
    {
        RuleFor(request => request.Email).EmailAddress().NotEmpty();
        RuleFor(request => request.EmailHash).NotEmpty();
    }
}