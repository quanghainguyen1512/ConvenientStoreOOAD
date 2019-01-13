using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.DAO
{
    [Table("sale_to_customer")]
    public class SaleToCustomerType
    {
        [Write(false)]
        public Sale Sale { get; set; }
        [Write(false)]
        public CustomerType CustomerType { get; set; }
    }
}
