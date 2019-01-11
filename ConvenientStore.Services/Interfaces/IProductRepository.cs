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
        IEnumerable<ProductDetail> GetProductDetails();

        ProductDetail GetProductDetailById(int productDetailId);

        ProductDetail GetProductdetailByBarCode(string barcode);

        bool IsProductDetailExist(string barcode);
    }
}
