using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.DAO
{
    [Table("DeliveryDetail")]
    public class DeliveryDetail
    {
        [Key]
        public int DeliveryDetailId { get; set; }
        public int Subcost { get; set; }
        
        [Write(false)]
        public Delivery Delivery { get; set; }

        [Write(false)]
        public Order Order { get; set; }
    }
}
