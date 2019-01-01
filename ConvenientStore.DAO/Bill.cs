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
        public DateTime CreatedDate { get; set; }

        [Write(false)]
        public Customer Customer { get; set; }

        [Write(false)]
        public List<BillDetail> BillDetails { get; set; }
    }
}
