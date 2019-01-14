using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.DTO
{
    public class ProductBillDto
    {
        public String Id { get; set; }
        public string DetailId { get; set; }
        public String ProductName { get; set; }
        public String SellRate { get; set; }
        public String Price { get; set; }
        public string Unit { get; set; }
        public string Index { get; set; }
        public string Quantity { get; set; }
        public string Barcode { get; set; }
        public String Message { get; set; }

        public string ImageUrl { get; set; } 
        public ProductBillDto() { }

        public string Total()
        {
            int sum = (Convert.ToInt32(Quantity) * Convert.ToInt32(Price.Replace(",",""))) 
                - (Convert.ToInt32(Quantity) * Convert.ToInt32(Price.Replace(",", ""))) * Convert.ToInt32(SellRate) / 100;

            return sum.ToString("#,#", CultureInfo.InvariantCulture);
        }

        public ProductBillDto(string id, string productName, string sellRate, string price, string unit, string message) : this(id)
        {
            ProductName = productName;
            SellRate = sellRate;
            Price = price;
            Unit = unit;
            Message = message;
        }

        public ProductBillDto(string message)
        {
            Message = message;
        }
    }
}
