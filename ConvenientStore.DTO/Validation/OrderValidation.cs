using ConvenientStore.DTO.Order;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.DTO.Validation
{
    public class OrderValidation : AbstractValidator<OrderForOperationsDto>
    {
        public OrderValidation()
        {
            RuleFor(o => o.OrderedDate).LessThanOrEqualTo(DateTime.Now).NotNull();
            RuleForEach(o => o.OrderDetails).Must(o => o.Validate().isValid);
        }
    }
}
