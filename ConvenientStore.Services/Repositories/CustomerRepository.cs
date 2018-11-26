using ConvenientStore.DAO;
using ConvenientStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using Dapper;
using Dapper.Mapper;
using Z.Dapper.Plus;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace ConvenientStore.Services.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public bool AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerById(int customerId)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                return con.Get<Customer>(customerId);
            }
        }

        public Customer GetCustomerByPhone(string phone)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                var query = "SELECT * FROM customer WHERE PhoneNumber = @phone";
                return con.QueryFirst<Customer>(query, param: new { phone });
            }
        }

        public IEnumerable<Customer> GetCustomers()
        {
            using (var con = DbConnection.Instance.Connection)
            {
                return con.GetAll<Customer>();
            }
        }

        public bool IsPhoneNumberExists(string phone)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                var query = "SELECT CustomerId FROM customer WHERE PhoneNumber = @phone";
                return con.ExecuteScalar(query, param: new { phone }) != null;
            }
        }
    }
}
