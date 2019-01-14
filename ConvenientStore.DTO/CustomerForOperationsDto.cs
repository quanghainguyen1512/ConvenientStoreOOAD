using ConvenientStore.DTO.Validation;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.DTO
{
    public class CustomerForOperationsDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool Gender { get; set; }
        public int Point { get; set; }
        public int TypeId { get; set; }

        //public (bool isValid, IEnumerable<ValidationResult> errors) Validate()
        //{
        //    var validator = new CustomerValidation();        //    var result = validator.Validate(this);        //    if (result.IsValid)
        //        return (true, null);
        //    return (false, result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName })));
        //}
    }
}
