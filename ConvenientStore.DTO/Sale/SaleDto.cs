using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.DTO.Sale
{
    public class SaleDto
    {
        public string ShortName { get; set; }
        public string Description { get; set; } = "";
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Value { get; set; }
        public string TypeOfDiscount { get; set; }    // false = coupon, true = voucher
        public int ConditionMin { get; set; }
        public string Status { get; set; }

        //public 
    }
}
