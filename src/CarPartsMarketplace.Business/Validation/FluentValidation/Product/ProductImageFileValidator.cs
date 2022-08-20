using CarPartsMarketplace.Business.Constant;
using FluentValidation;
using Microsoft.AspNetCore.Http;

namespace CarPartsMarketplace.Business.Validation.FluentValidation.Product;

public class ProductImageFileValidator : AbstractValidator<IFormFile>
{
    public ProductImageFileValidator()
    {
        RuleFor(x => x.Length).NotNull().LessThanOrEqualTo(400000)
            .WithMessage(Messages.FILE_TYPE_IS_LARGER_THAN_ALLOWED);

        RuleFor(x => x.ContentType).NotNull().Must(x => x.Equals("image/jpeg") || x.Equals("image/jpg") || x.Equals("image/png"))
            .WithMessage(Messages.FILE_TYPE_IS_NOT_ALLOWED);
    }
}