using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.DTO
{
     public class CustomerBillDto
    {

        public CustomerBillDto()
        {

        }

        public CustomerBillDto(String id, String fullName, String phoneNumber, String message)
        {
            this.Id = id;
            this.FullName = fullName;
            this.PhoneNumer = phoneNumber;
            this.Message = message;
        }

        public CustomerBillDto(String message)
        {
            this.Message = message;
        }

        public String Id { get; set; }

        public String FullName { get; set; }

        public String PhoneNumer { get; set; }

        public string Point { get; set; }

        public string CusType { get; set; }

        public String Message { get; set; }
    }

}
