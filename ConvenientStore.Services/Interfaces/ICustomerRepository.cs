using ConvenientStore.DAO;
using System.Collections.Generic;

namespace ConvenientStore.Services.Interfaces
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomerById(int customerId);
        Customer GetCustomerByPhone(string phone);
        bool AddCustomer(Customer customer);
        bool DeleteCustomer(Customer customer);
        bool IsPhoneNumberExists(string phone);
    }
}
