using ConvenientStore.DTO.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.DTO.Sale
{
    public class SaleForOperationsDto
    {
        public string ShortName { get; set; }
        public string Description { get; set; } = "";
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Value { get; set; }
        public bool TypeOfDiscount { get; set; }    // false = coupon, true = voucher
        public int ConditionMin { get; set; }

        public (bool isValid, IEnumerable<ValidationResult> errors) Validate()
        {
            var validator = new SaleValidation();            var result = validator.Validate(this);            if (result.IsValid)
                return (true, null);
            return (false, result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName })));
        }
    }
}
