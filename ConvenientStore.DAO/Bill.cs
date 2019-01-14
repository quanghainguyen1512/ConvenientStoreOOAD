using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.DAO
{
    [Table("bill")]

    public class Bill
    {
        [Key]
        public int BillId { get; set; }

        public DateTime CreateDate { get; set; }

        public int CustomerId { get; set; }

        public int Total { get; set; }

        public bool Status { get; set; }

        [Write(false)]
        public Customer Customer { get; set; }

        [Write(false)]
        public List<BillDetail> BillDetails { get; set; }
    }
}
