using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.DTO
{
    public class ProductManagementDetailDto
    {
        public string Id { get; set; }
        public string GeneratedCode { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
        public string Unit { get; set; }
        public string ExpirationDate { get; set; }
    }
}
