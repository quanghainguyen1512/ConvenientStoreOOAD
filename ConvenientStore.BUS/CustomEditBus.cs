using ConvenientStore.DAO;
using ConvenientStore.Services.Interfaces;
using ConvenientStore.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.BUS
{
    public class CustomEditBus
    {
        private ICustomerRepository customerRepository;

        public CustomEditBus()
        {
            this.customerRepository = new CustomerRepository();
        }

        public string GetCustomerTypeName(int customerId)
        {
            Customer customer = this.customerRepository.GetByIdWithType(customerId);
            return customer.CustomerType.Name;
        }

        public string Update(List<string> lists)
        {
            string result = "";
            Customer customer = this.customerRepository.GetById(Convert.ToInt32(lists[0]));
            string fullName = lists[1];
            string[] listName = fullName.Split(' ');
            string fistName = listName[0];
            string lastName = "";

            if (listName.Length > 1)
            {
                for(int i = 1; i < listName.Length; i++)
                {
                    lastName += listName[i] + " ";
                }
            }

            lastName = lastName.Trim();

            customer.FirstName = fistName;
            customer.LastName = lastName;

            customer.PhoneNumber = lists[3];
            customer.Email = lists[4];

            customer.DateOfBirth = DateTime.Parse(lists[2]);

            try
            {
                this.customerRepository.Update(customer);
            }
            catch
            {
                result += "Lỗi";
            }
            return result;
        }
    }
}
