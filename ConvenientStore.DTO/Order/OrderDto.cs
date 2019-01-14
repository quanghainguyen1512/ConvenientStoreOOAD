using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.DTO.Order
{
    public class OrderDto
    {
        public DateTime OrderedDate { get; set; }
        public IEnumerable<OrderDetailDto> OrderDetails { get; set; }
    }
}
