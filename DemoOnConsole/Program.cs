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
            //ICustomerRepository cusRepo = new CustomerRepository();
            //var cus = cusRepo.GetCustomerById(1);
            var cus = CustomerBus.Instance.GetCustomerById(1);
            //Console.WriteLine(cus.FirstName);
            //var cusdto = Mapping.Mapper.Map<CustomerDto>(cus);
            Console.WriteLine(cus.FullName);
        }
    }
}
