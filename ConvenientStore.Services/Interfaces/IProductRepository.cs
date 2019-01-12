using ConvenientStore.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.Services.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();

        Product GetProductById(int productId);

        Product GetProductByBarcode(string barcode);

    }
}
