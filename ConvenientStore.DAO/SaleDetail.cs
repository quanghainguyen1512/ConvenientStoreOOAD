using Dapper.Contrib.Extensions;

namespace ConvenientStore.DAO
{
    [Table("sale_detail")]
    public class SaleDetail
    {
        [Key]
        public int SaleDetailId { get; set; }
        public string Description { get; set; }

        [Write(false)]
        public Product Product { get; set; }
        
        //[Write(false)]
        //public Sale Sale { get; set; }
    }
}