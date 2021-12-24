using Business.Constants;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage(Messages.ProductNameNotEmpty);
            RuleFor(p => p.ProductName).Length(2, 30).WithMessage(Messages.ProductNameLengthError);
            RuleFor(p => p.UnitPrice).NotEmpty().WithMessage(Messages.UnitPriceNotEmpty);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(1).WithMessage(Messages.UnitPriceMinimumError);
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1).WithMessage(Messages.UnitPriceCategoryMinimumError);
            //Aşağıdaki custom kural kontrol örneğidir
            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage(Messages.ProductNameFirstDigitError);
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}