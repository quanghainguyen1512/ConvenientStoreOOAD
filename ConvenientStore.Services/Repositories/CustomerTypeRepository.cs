using ConvenientStore.DAO;
using ConvenientStore.Services.Interfaces;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.Services.Repositories
{
    public class CustomerTypeRepository : ICustomerTypeRepository
    {
        public bool Add(CustomerType obj)
        {
            throw new NotImplementedException();
        }

        public bool AddRange(IEnumerable<CustomerType> objs)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerType> GetAll()
        {
            using (var con = DbConnection.Instance.Connection)
            {
                return con.GetAll<CustomerType>();
            }
        }

        public CustomerType GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(CustomerType obj)
        {
            throw new NotImplementedException();
        }
    }
}
