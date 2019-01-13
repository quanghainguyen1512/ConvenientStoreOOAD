using Dapper.Contrib.Extensions;

namespace ConvenientStore.DAO
{
    [Table("combo")]
    public class Combo
    {
        [Key]
        public int ComboId { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }
}
