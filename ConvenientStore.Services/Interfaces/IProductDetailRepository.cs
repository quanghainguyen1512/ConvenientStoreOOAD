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
        ProductDetail GetProductDetailByProductIdAndMinExpidationDate(int productId);
        ProductDetail GetProductDetailByGeneratedCode(string generatedCode);
    }
}
