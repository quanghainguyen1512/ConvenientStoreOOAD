using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.DTO
{
    public class ProductBillDto
    {
        public String Id { get; set; }
        public String ProductName { get; set; }
        public String SellRate { get; set; }
        public String Price { get; set; }
        public String Message { get; set; }

        public ProductBillDto() { }

        public ProductBillDto(string id, string productName, string sellRate, string price, string message)
        {
            Id = id;
            ProductName = productName;
            SellRate = sellRate;
            Price = price;
            Message = message;
        }

        public ProductBillDto(string message)
        {
            Message = message;
        }
    }
}
