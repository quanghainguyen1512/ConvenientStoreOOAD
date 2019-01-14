using System;
using FluentValidation;

namespace ConvenientStore.DTO.Validation
{
    public class CustomerValidation : AbstractValidator<Customer.CustomerForOperationsDto>
    {
        public CustomerValidation()
        {
            RuleFor(s => s.FirstName).MaximumLength(45).NotEmpty();
            RuleFor(s => s.LastName).MaximumLength(45).NotEmpty();
            RuleFor(s => s.DateOfBirth).LessThan(DateTime.Today).WithMessage("The date of birth must be less than current date");
            RuleFor(s => s.PhoneNumber)
                .MinimumLength(10)
                .MaximumLength(11)
                .Matches(@"(0[^0][0-9]{8,9})\b")
                .NotNull().WithMessage("Số điện thoại không hợp lệ");
            RuleFor(s => s.Email).Matches(@"^[a-z][a-z0-9_\.]{5,32}@[a-z0-9]{2,}(\.[a-z0-9]{2,4}){1,2}$");
        }
    }
}
