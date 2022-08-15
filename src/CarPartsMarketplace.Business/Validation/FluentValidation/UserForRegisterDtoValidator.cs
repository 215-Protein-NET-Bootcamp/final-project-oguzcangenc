using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                .MinimumLength(8)
                .Equal(request => request.ConfirmPassword).WithMessage(Messages.PASSWORD_NOT_MATCH);

            RuleFor(request => request.ConfirmPassword).NotEmpty();
            RuleFor(request => request.FirstName).NotEmpty();
            RuleFor(request => request.LastName).NotEmpty();


        }
    }
    public class UserForLoginDtoValidator : AbstractValidator<UserLoginDto>
    {
        public UserForLoginDtoValidator()
        {
            RuleFor(request => request.Email).EmailAddress().NotEmpty();
            RuleFor(request => request.Password).NotEmpty();


        }
    }    
}
