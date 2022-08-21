using CarPartsMarketplace.Entities.Dtos.Color;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarPartsMarketplace.Entities.Dtos.Offer;

namespace CarPartsMarketplace.Business.Validation.FluentValidation.Offer
{
    public class CreateOfferDtoValidator : AbstractValidator<CreateOfferDto>
    {
        public CreateOfferDtoValidator()
        {
            RuleFor(request => request.ProductId).NotEmpty();
            RuleFor(request => request.IsPercentPrice).NotNull();
            RuleFor(request => request.Price).NotEmpty();
        }
    }
}
