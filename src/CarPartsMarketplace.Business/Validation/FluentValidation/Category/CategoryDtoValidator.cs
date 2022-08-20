using CarPartsMarketplace.Entities.Dtos.Brand;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPartsMarketplace.Entities.Dtos.Category;

namespace CarPartsMarketplace.Business.Validation.FluentValidation.Category
{
    public class CategoryDtoValidator : AbstractValidator<CategoryDto>
    {
        public CategoryDtoValidator()
        {
            RuleFor(request => request.Name).NotEmpty();
        }
    }
}
