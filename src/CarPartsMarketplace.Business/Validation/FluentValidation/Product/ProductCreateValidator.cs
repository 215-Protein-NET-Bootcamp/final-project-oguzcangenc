using FluentValidation;
using CarPartsMarketplace.Entities.Dtos.Product;

namespace CarPartsMarketplace.Business.Validation.FluentValidation.Product
{
    public class ProductCreateValidator : AbstractValidator<CreateProductDto>
    {
        public ProductCreateValidator()
        {
            RuleFor(request => request.Name).MaximumLength(100).NotEmpty();
            RuleFor(request => request.Description).MaximumLength(500).NotEmpty();
            RuleFor(request => request.CategoryId).NotEmpty();
            RuleFor(request => request.UsageId).NotEmpty();
            RuleFor(request => request.Image).NotEmpty().SetValidator(new ProductImageFileValidator());
            RuleFor(request => request.Price).NotEmpty();


        }
    }
}
