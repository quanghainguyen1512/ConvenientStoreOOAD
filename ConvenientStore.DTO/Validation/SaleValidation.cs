using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace ConvenientStore.DTO.Validation
{
    public class SaleValidation : AbstractValidator<Sale.SaleForOperationsDto>
    {
        public SaleValidation()
        {
            RuleFor(s => s.ShortName).Matches("^[A-Z0-9]{3}(?:List)?$").MaximumLength(45).NotNull();
            RuleFor(s => s.Value).GreaterThan(0).NotNull();
            RuleFor(s => s.ConditionMin).GreaterThan(0).NotNull();
            RuleFor(s => s.StartDate).LessThan(s => s.EndDate).NotNull();
            RuleFor(s => s.EndDate).GreaterThan(s => s.StartDate).NotNull();
        }
    }
}
