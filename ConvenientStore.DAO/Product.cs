using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.DAO
{
    [Table("product")]
    public class Product
    {
        [ExplicitKey]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public string ImageUrl { get; set; }        public int CategoryId { get; set; }

        [Write(false)]
        public Category Category { get; set; }
        //[Write(false)]
        //public ICollection<ProductDetail> Details { get; set; }
    }
}
