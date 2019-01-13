using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.DTO
{
    public class ProductDto
    {
        public string Name { get; set; }
        public string Unit { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string Barcode { get; set; }
    }
}
