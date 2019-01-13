using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.DAO
{
    [Table("bill_detail")]
    public class BillDetail
    {
        [Key]
        public int BillDetailId { get; set; }
        public int Quantity { get; set; }

        public int ProductDetailId { get; set; }

        public int BillId { get; set; }

        [Write(false)]
        public ProductDetail ProductDetail { get; set; }
        
        [Write(false)]
        public Bill Bill { get; set; }
    }
}
