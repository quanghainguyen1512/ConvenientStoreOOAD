using ConvenientStore.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.Services.Interfaces
{
    public interface IProductDetailRepository : IRepository<ProductDetail>
    {
        //IEnumerable<ProductDetail> GetAllProductDetails();
        ProductDetail GetByBarcode(string barcode);
        //ProductDetail GetProductDetailById(int id);
        //bool UpdateProductDetail(ProductDetail productDetail);
        //bool AddProductDetail(ProductDetail productDetail);

    }
}
