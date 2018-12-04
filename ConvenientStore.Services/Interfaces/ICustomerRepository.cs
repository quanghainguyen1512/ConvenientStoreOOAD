using ConvenientStore.DAO;
using System.Collections.Generic;

namespace ConvenientStore.Services.Interfaces
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomerById(int customerId, bool withType = false);
        Customer GetCustomerByPhone(string phone, bool withType = false);
        bool AddCustomer(Customer customer);
        bool DeleteCustomer(Customer customer);
        bool CheckPhoneNumberExists(string phone);
    }
}
