using ConvenientStore.DAO;
using ConvenientStore.Services.Interfaces;
using Dapper;
using Dapper.Contrib.Extensions;
using Dapper.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.Services.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public bool Add(Product obj)
        {
            throw new NotImplementedException();
        }

        public bool AddRange(IEnumerable<Product> objs)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            using (var con = DbConnection.Instance.Connection)
            {
                return con.GetAll<Product>();
            }
        }

        public Product GetByBarcode(string barcode)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                var sql = "SELECT * FROM product WHERE Barcode like @barcode";
                return con.Query<Product>(sql, param: new { barcode }).FirstOrDefault();
            }
        }

        public Product GetById(int id)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                return con.Get<Product>(id);
            }
        }

        public Product GetByIdWithCategory(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProductsByName(string name)
        {
            throw new NotImplementedException();
        }

        public bool Update(Product obj)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                return con.Update(obj);
            }
        }
    }
}
