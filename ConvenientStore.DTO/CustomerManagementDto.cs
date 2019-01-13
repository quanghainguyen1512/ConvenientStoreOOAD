using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.DTO
{
    public class CustomerManagementDto
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Index { get; set; }
        public string PhoneNumber { get; set; }
        public string DateOfBirth { get; set; }
        public string Point { get; set; }
        public string CusType { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }

        public string fullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public CustomerManagementDto() { }

        public CustomerManagementDto(string id, string firstName, string lastName, string phoneNumber, string dateOfBirth, string point, string message)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            DateOfBirth = dateOfBirth;
            Point = point;
            Message = message;
        }

        public CustomerManagementDto(string message)
        {
            this.Message = message;
        }
    }
}
