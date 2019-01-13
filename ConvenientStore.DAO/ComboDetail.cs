using Dapper.Contrib.Extensions;

namespace ConvenientStore.DAO
{
    [Table("combo_detail")]
    public class ComboDetail
    {
        [Write(false)]
        public ProductDetail ProductDetail { get; set; }
        [Write(false)]
        public Combo Combo { get; set; }
    }
}
