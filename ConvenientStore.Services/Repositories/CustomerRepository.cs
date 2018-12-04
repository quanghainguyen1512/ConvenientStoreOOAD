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
            using (var con = DbConnection.Instance.Connection)
            {
                return con.Insert(customer) != 0;
            }
        }

        public bool DeleteCustomer(Customer customer)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                return con.Delete(customer);
            }
        }

        public Customer GetCustomerById(int customerId, bool withType = false)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                if (withType)
                {
                    var sql = "SELECT * FROM customer as c " +
                        "INNER JOIN customer_type as ct " +
                        "ON c.CusTypeId = ct.TypeId " +
                        "WHERE c.CustomerId = @customerId";
                    return con.Query<Customer, CustomerType>(sql, splitOn: "TypeId", param: new { customerId }).FirstOrDefault();
                }
                return con.Get<Customer>(customerId);
            }
        }

        public Customer GetCustomerByPhone(string phone, bool withType = false)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                if (withType)
                {
                    var sql = "SELECT * FROM customer as c " +
                        "INNER JOIN customer_type as ct " +
                        "ON c.CusTypeId = ct.TypeId " +
                        "WHERE c.PhoneNumber = @phone";
                    return con.Query<Customer, CustomerType>(sql, splitOn: "TypeId", param: new { phone }).FirstOrDefault();
                }
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

        public bool CheckPhoneNumberExists(string phone)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                var query = "SELECT CustomerId FROM customer WHERE PhoneNumber = @phone";
                return con.ExecuteScalar(query, param: new { phone }) != null;
            }
        }
    }
}
