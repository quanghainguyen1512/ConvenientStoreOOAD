using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.DAO
{
    [Table("customer_type")]
    public class CustomerType
    {
        [Key]
        public int TypeId { get; set; }
        public string Name { get; set; }

        [Write(false)]
        public ICollection<Customer> Customers { get; set; }

    }
}
