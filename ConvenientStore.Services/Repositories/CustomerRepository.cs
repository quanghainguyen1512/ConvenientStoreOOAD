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
        //public bool DeleteCustomer(Customer customer)
        //{
        //    using (var con = DbConnection.Instance.Connection)
        //    {
        //        return con.Delete(customer);
        //    }
        //}

        public Customer GetByIdWithType(int customerId)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                var sql = "SELECT * FROM customer as c " +
                         "INNER JOIN customer_type as ct " +
                         "ON c.CusTypeId = ct.TypeId " +
                         "WHERE c.CustomerId = @customerId";
                return con.Query<Customer, CustomerType>(sql, splitOn: "TypeId", param: new { customerId }).FirstOrDefault();
            }
        }

        public Customer GetByPhone(string phone, bool withType = false)
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

        public bool CheckPhoneNumberExists(string phone)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                var query = "SELECT CustomerId FROM customer WHERE PhoneNumber = @phone";
                return con.ExecuteScalar(query, param: new { phone }) != null;
            }
        }

        public IEnumerable<Customer> GetAll()
        {
            using (var con = DbConnection.Instance.Connection)
            {
                return con.GetAll<Customer>();
            }
        }

        public Customer GetById(int id)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                return con.Get<Customer>(id);
            }
        }

        public bool Add(Customer obj)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                return con.Insert(obj) != 0;
            }
        }

        public bool AddRange(IEnumerable<Customer> objs)
        {
            throw new NotImplementedException();
        }

        public bool Update(Customer obj)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomerByPhoneNumber(string phoneNumber)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                Customer customer = null;
                var query = "SELECT * FROM customer WHERE PhoneNumber = @phoneNumber";
                try
                {
                    customer = con.QueryFirst<Customer>(query, param: new { phoneNumber });

                }
                catch
                {
                    Console.WriteLine("Không tìm thấy khách hàng");
                }
                return customer;
            }
        }
    }
}
