using CarPartsMarketplace.Business.Constant;
using CarPartsMarketplace.Entities.Dtos;
using FluentValidation;

namespace CarPartsMarketplace.Business.Validation.FluentValidation
{
    public class UserForRegisterDtoValidator : AbstractValidator<UserForRegisterDto>
    {
        public UserForRegisterDtoValidator()
        {
            RuleFor(request => request.Email).EmailAddress().NotEmpty();
            RuleFor(request => request.Password)
                .NotEmpty()
                .Matches("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,20}$").WithMessage(Messages.PASSWORD_NOT_MATCH_REGEX)
                .Equal(request => request.ConfirmPassword).WithMessage(Messages.PASSWORD_NOT_MATCH);
            RuleFor(request => request.ConfirmPassword).NotEmpty();
            RuleFor(request => request.FirstName).NotEmpty();
            RuleFor(request => request.LastName).NotEmpty();
        }
    }
}
