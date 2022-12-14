using CarPartsMarketplace.Entities.Dtos.Brand;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPartsMarketplace.Entities.Dtos.Color;

namespace CarPartsMarketplace.Business.Validation.FluentValidation.Category
{
    public class ColorDtoValidator : AbstractValidator<ColorDto>
    {
        public ColorDtoValidator()
        {
            RuleFor(request => request.Name).NotEmpty();
        }
    }
}
