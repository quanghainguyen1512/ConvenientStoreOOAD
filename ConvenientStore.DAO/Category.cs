using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace ConvenientStore.DAO
{
    [Table("category")]
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }

        [Write(false)]
        public ICollection<Product> Products { get; set; }
    }
}
