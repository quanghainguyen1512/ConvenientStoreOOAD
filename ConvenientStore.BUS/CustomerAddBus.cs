using ConvenientStore.DAO;
using ConvenientStore.DTO;
using ConvenientStore.Helpers.Message;
using ConvenientStore.Services.Interfaces;
using ConvenientStore.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConvenientStore.BUS
{
    

    public class CustomerAddBus
    {
        private ICustomerTypeRepository customerTypeRepository;
        private ICustomerRepository customerRepository;

        public CustomerAddBus()
        {
            this.customerTypeRepository = new CustomerTypeRepository();
            this.customerRepository = new CustomerRepository();
        }

        public List<CustomerTypeDto> GetAllCustomerType()
        {
            List<CustomerTypeDto> customerTypeDtos = new List<CustomerTypeDto>();

            List<CustomerType> customerTypes = this.customerTypeRepository.GetAll().ToList();

            foreach(CustomerType ct in customerTypes)
            {
                CustomerTypeDto dto = new CustomerTypeDto();
                dto.Id = ct.TypeId.ToString();
                dto.Name = ct.Name;
                dto.Message = "";
                customerTypeDtos.Add(dto);
            }

            return customerTypeDtos;
        }

        public string Submit(List<string> lists)
        {
            string result = "";

            Customer customer = new Customer();



            string fullName = lists[0];
            string[] stringTemp = fullName.Trim().Split(' ');

            string firstName = stringTemp[0];
            string lastName = "";
            if (stringTemp.Length > 1)
            {
                for (int i = 1; i < stringTemp.Length; i++)
                {
                    lastName += (stringTemp[i] + " ");
                }
            }

            customer.FirstName = firstName;
            customer.LastName = lastName;

            customer.FirstName = Convert.ToBase64String(ASCIIEncoding.UTF8.GetBytes(customer.FirstName));
            customer.LastName = Convert.ToBase64String(ASCIIEncoding.UTF8.GetBytes(customer.LastName));

            customer.DateOfBirth = DateTime.Parse(lists[1]);

            customer.PhoneNumber = lists[2];
            customer.Email = lists[3];
            customer.CusTypeId = Convert.ToInt32(lists[4]);
            customer.Gender = "Nam".Equals(lists[5].Trim()) ? true : false;

            if("".Equals(fullName.Trim()))
            {
                result += String.Format(MessageContent.EMPTY_FIELD_ERROR, "Tên khách hàng") + MessageContent.BREAK_LINE;
            }

            result += this.validateEmail(customer.Email);

            result += this.validatePhone(customer.PhoneNumber);

            if(!"".Equals(result.Trim()))
            {
                return result;
            }

            try
            {
                this.customerRepository.Add(customer);
            }
            catch
            {
                result += String.Format(MessageContent.ADD_CUSTOMER_ERROR, fullName) + MessageContent.BREAK_LINE;
            }

            return result;
        }

        private string validateEmail(string email)
        {
            string result = "";

            if(!Regex.IsMatch(email.Trim(), @"^[a-z][a-z0-9_\.]{4,32}@[a-z0-9]{2,}(\.[a-z0-9]{2,4}){1,2}$"))
            {
                result += String.Format(MessageContent.INVALID_EMAIL, email) + MessageContent.BREAK_LINE;
            }

            if(this.customerRepository.CheckEmailExist(email.Trim()))
            {
                result += String.Format(MessageContent.EMAIL_IS_EXIST, email) + MessageContent.BREAK_LINE;
            }

            return result;
        }

        private string validatePhone(string phone)
        {
            string result = "";

            if (!Regex.IsMatch(phone.Trim(), @"(0[^0][0-9]{8,9})\b"))
            {
                result += String.Format(MessageContent.INVALID_PHONE, phone) + MessageContent.BREAK_LINE;
            }

            if (this.customerRepository.CheckPhoneNumberExists(phone.Trim()))
            {
                result += String.Format(MessageContent.PHONE_IS_EXIST, phone) + MessageContent.BREAK_LINE;
            }

            return result;
        }
    }
}
