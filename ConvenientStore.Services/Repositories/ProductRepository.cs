using ConvenientStore.DAO;
using ConvenientStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.Services.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public ProductDetail GetProductdetailByBarCode(string barcode)
        {
            throw new NotImplementedException();
        }

        public ProductDetail GetProductDetailById(int productDetailId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductDetail> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public bool IsProductDetailExist(string barcode)
        {
            throw new NotImplementedException();
        }
    }
}
