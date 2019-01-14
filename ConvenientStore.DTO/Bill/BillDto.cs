using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.DTO.Bill
{
    public class BillDto
    {
        public int BillId { get; set; }

        public DateTime CreateDate { get; set; }
        public int Total { get; set; }
        public string CustomerName { get; set; }
        public IEnumerable<BillDetailDto> BillDetails { get; set; }
    }
}
