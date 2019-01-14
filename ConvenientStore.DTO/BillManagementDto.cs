using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.DTO
{
    public class BillManagementDto
    {
        public string Id { get; set; }
        public string Index { get; set; }
        public string CustomerName { get; set; }
        public string CreateDate { get; set; }
        public string Total { get; set; }
        public string Message { get; set; }

        public string PhoneNumber { get; set; }

        public string Code()
        {
            return Convert.ToInt32(Id).ToString("000000");
        }

        public BillManagementDto(string id, string customerName, string createDate, string total, string message)
        {
            Id = id;
            CustomerName = customerName;
            CreateDate = createDate;
            Total = total;
            Message = message;
        }

        public BillManagementDto() { }

        public BillManagementDto(string message)
        {
            this.Message = message;
        }


    }
}
