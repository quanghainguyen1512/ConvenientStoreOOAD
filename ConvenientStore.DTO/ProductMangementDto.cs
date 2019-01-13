using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.DTO
{
    public class ProductMangementDto
    {
        public string Id { get; set; }
        public string ProductName { get; set; }
        public string Barcode { get; set; }
        public string Quantity { get; set; }
        public string Unit { get; set; }
        public string Index { get; set; }

        public string ImageUrl { get; set; }
        public string Message { get; set; }

        public ProductMangementDto() { }

        public ProductMangementDto(string id, string productName, string barcode, string quantity, string unit, string message)
        {
            Id = id;
            ProductName = productName;
            Barcode = barcode;
            Quantity = quantity;
            Unit = unit;
            Message = message;
        }

        public ProductMangementDto(string message)
        {
            Message = message;
        }
    }
}
