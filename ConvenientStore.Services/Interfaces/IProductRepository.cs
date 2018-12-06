using ConvenientStore.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.Services.Interfaces
{
    public interface IProductRepository : IRepository<Product>
    {
        //IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetProductsByName(string name);
        //bool AddProduct(Product product);
        //bool UpdateProduct(Product product);
    }
}
