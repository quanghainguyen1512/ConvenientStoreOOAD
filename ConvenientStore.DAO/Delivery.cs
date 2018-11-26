using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.DAO
{
    [Table("delivery")]
    public class Delivery
    {
        [Key]
        public int DeliveryId { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int TotalCost { get; set; }

        [Write(false)]
        public ICollection<DeliveryDetail> DeliveryDetails { get; set; }
    }
}
