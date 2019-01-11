using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.DAO
{
    [Table("product_detail")]
    public class ProductDetail
    {
        [Key]
        public int ProductDetailId { get; set; }

        //[Write(false)]
        public int Quantity { get; set; }

        //[Write(false)]
        public int Price { get; set; }

        //[Write(false)]
        public DateTime ExpirationDate { get; set; }

        [Write(false)]
        public Product Product { get; set; }
    }
}
