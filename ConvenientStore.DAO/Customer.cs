using Dapper.Contrib.Extensions;
using System;

namespace ConvenientStore.DAO
{
    [Table("customer")]
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public bool Gender { get; set; }
        public int Point { get; set; }
        public int CusTypeId { get; set; }

        [Write(false)]
        public CustomerType CustomerType { get; set; }
    }
}
