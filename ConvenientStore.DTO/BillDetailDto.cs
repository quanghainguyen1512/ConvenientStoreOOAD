using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.DTO
{
    public class BillDetailDto
    {
        public string Id { get; set; }
        public string Index { get; set; }
        public string Message { get; set; }
        public string ProductCode { get; set; }
        public  string ProduceName { get; set; }
        public  string Sale { get; set; }
        public  string Price { get; set; }
        public  string Unit { get; set; }
        public  string Total { get; set; }
        public  string Quantity { get; set; }
    }
}
