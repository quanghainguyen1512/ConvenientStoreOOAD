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

        public bool CheckBarCodeExists(string barcode)
        {
            var sql = "SELECT ProductId FROM product WHERE Barcode = @barcode";
            using (var con = DbConnection.Instance.Connection)
            {
                return con.ExecuteScalar(sql, param: new { barcode }) != null;
            }
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
                var sql = "SELECT * FROM product WHERE Barcode = @barcode";
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
            using (var con = DbConnection.Instance.Connection)
            {
                var sql = "SELECT * FROM product as p INNER JOIN category as c ON p.CategoryId = c.CategoryId WHERE ProductId = @id";
                return con.Query<Product, Category>(sql, param: new { id }).FirstOrDefault();
            }
        }

        public IEnumerable<Product> GetProductsByName(string name)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                name = $"%{name}%";
                var sql = $"SELECT * FROM product WHERE Name LIKE @name";
                return con.Query<Product>(sql, param: new { name });
            }
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
