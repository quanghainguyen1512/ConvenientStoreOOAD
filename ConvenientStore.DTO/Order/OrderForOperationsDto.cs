using ConvenientStore.DTO.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.DTO.Order
{
    public class OrderForOperationsDto
    {
        public DateTime OrderedDate { get; set; }
        public List<OrderDetailForOperationsDto> OrderDetails { get; set; }
        public (bool isValid, IEnumerable<ValidationResult> errors) Validate()
        {
            var validator = new OrderValidation();
            var result = validator.Validate(this);
            if (result.IsValid)
                return (true, null);
            return (false, result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName })));
        }
    }
}
