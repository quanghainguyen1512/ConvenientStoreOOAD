using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.DAO
{
    [Table("sale")]
    public class Sale
    {
        [Key]
        public int SaleId { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        [Write(false)]
        public ICollection<SaleDetail> SaleDetails { get; set; }
    }
}
