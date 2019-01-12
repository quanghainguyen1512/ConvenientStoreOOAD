using ConvenientStore.DAO;
using ConvenientStore.Services.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.Services.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Product GetProductByBarcode(string barcode)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                Product product = null;
                var query = "SELECT * FROM product WHERE Barcode = @barcode";
                try
                {
                    product = con.QueryFirst<Product>(query, param: new { barcode });
                }
                catch
                {
                    Console.WriteLine("Không tìm thấy thông tin sản phẩm");
                }
                return product;
            }
        }

        public Product GetProductById(int productId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            throw new NotImplementedException();
        }
    }
}
