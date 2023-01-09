using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.CategoryId).NotEmpty();

            RuleFor(p => p.ProductName).NotEmpty();

            RuleFor(p => p.UnitsInStock).NotEmpty();
            RuleFor(p => p.UnitsInStock).GreaterThan(0);

            RuleFor(p => p.ProductCode).NotEmpty();
            RuleFor(p => p.ProductCode).Must(StartWithCode).WithMessage("Ürünkodu SGC6160 ile başlamalıdır.");
            RuleFor(p => p.ProductCode).MinimumLength(13);

            RuleFor(p => p.ProductBarcode).NotEmpty();
            RuleFor(p => p.ProductBarcode).Must(StartWithBarcode).WithMessage("Ürünkodu 8686160 ile başlamalıdır.");
            RuleFor(p => p.ProductBarcode).MinimumLength(13);

            RuleFor(p => p.ProductDescription).NotEmpty();

        }
        private bool StartWithCode(string arg)
        {
            return arg.StartsWith("SGC6160");
        }
        private bool StartWithBarcode(string arg)
        {
            return arg.StartsWith("8686160");
        }
    }
}
