using ConvenientStore.Services.Interfaces;
using ConvenientStore.Services.Repositories;
using ConvenientStore.Helpers.MappingHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConvenientStore.DTO;
using System.Configuration;
using ConvenientStore.BUS;

namespace DemoOnConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString);
            ICustomerRepository cusRepo = new CustomerRepository();
            var cus = cusRepo.GetCustomerByPhoneNumber("01283550324");
            Console.WriteLine(cus.FirstName);
            var cusDto = Mapping.mapperCustomerBill.Map<CustomerBillDto>(cus);
            Console.WriteLine(cusDto.FullName);
            Console.ReadLine();
        }
    }
}
