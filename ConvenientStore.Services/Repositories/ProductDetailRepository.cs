using System.Collections.Generic;
using System.Linq;
using ConvenientStore.DAO;
using ConvenientStore.Services.Interfaces;
using Dapper;
using Dapper.Contrib.Extensions;

namespace ConvenientStore.Services.Repositories
{
    public class ProductDetailRepository : IProductDetailRepository
    {
        public bool Add(ProductDetail obj)
        {
            throw new System.NotImplementedException();
        }

        public bool AddRange(IEnumerable<ProductDetail> objs)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ProductDetail> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public ProductDetail GetById(int id)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                return con.Get<ProductDetail>(id);
            }
        }

        public ProductDetail GetProductDetailByGeneratedCode(string generatedCode)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                generatedCode = $"{generatedCode}%";
                var query = "select * from product_detail where product_detail.GeneratedCode like @generatedCode";
                return con.Query<ProductDetail>(query, param: new { generatedCode }).FirstOrDefault();
            }
        }

        public ProductDetail GetProductDetailByProductIdAndMinExpidationDate(int productId)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                var query = "select * from product_detail where product_detail.ProductId = @productId and Quantity > 0 " +
                            "order by product_detail.ExpirationDate asc " +
                            "limit 1";
                return con.Query<ProductDetail>(query, param: new { productId }).FirstOrDefault();
            }
        }

        public bool Update(ProductDetail obj)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                return con.Update(obj);
            }
        }


    }
}
