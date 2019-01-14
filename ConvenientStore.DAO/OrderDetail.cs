using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.DAO
{
    [Table("order_detail")]
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { get; set; }
        public int Quantity { get; set; }
        public bool Status { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }

        [Write(false)]
        public Product Product { get; set; }
        
        [Write(false)]
        public Order Order { get; set; }
    }
}
