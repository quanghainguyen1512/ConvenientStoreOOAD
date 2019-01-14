using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConvenientStore.DTO.Order;
using FluentValidation;

namespace ConvenientStore.DTO.Validation
{
    public class OrderDetailValidation : AbstractValidator<OrderDetailForOperationsDto>
    {
        public OrderDetailValidation()
        {
            RuleFor(od => od.Quantity).GreaterThan(0).NotNull();
        }
    }
}
