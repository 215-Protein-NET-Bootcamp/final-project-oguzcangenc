using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPartsMarketplace.Entities.Dtos.ApplicationUser;
using CarPartsMarketplace.Entities.Dtos.Brand;
using FluentValidation;

namespace CarPartsMarketplace.Business.Validation.FluentValidation.Brand
{
    public class BrandDtoValidator : AbstractValidator<BrandDto>
    {
        public BrandDtoValidator()
        {
            RuleFor(request => request.Name).NotEmpty();
        }
    }
}
