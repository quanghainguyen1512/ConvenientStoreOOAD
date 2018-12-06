using ConvenientStore.DAO;
using System.Collections.Generic;

namespace ConvenientStore.Services.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        //IEnumerable<Customer> GetCustomers();
        //Customer GetCustomerById(int customerId, bool withType = false);
        Customer GetByIdWithType(int id);
        Customer GetByPhone(string phone, bool withType = false);
        //bool AddCustomer(Customer customer);
        //bool DeleteCustomer(Customer customer);
        bool CheckPhoneNumberExists(string phone);
    }
}
