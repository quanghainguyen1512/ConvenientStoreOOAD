using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.DTO.Order
{
    public class OrderForOperations
    {
        public DateTime OrderedDate { get; set; }
        public List<OrderDetailForOperationsDto> OrderDetails { get; set; }
    }
}
