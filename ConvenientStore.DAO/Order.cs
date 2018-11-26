using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.DAO
{
    [Table("order_action")]
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderedDate { get; set; }        
        [Write(false)]
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
