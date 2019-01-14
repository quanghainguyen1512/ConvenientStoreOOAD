using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.DTO.Product
{
    public class ProductDetailForOperationsDto
    {
        public int Quantity { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int Price { get; set; }
    }
}
