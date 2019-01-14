using ConvenientStore.DAO;
using System.Collections.Generic;

namespace ConvenientStore.Services.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer>
    {

        Customer GetByIdWithType(int id);
        Customer GetByPhone(string phone, bool withType = false);
        IEnumerable<Customer> GetByName(string name, bool withType = false);
        bool CheckPhoneNumberExists(string phone);

    }
}
