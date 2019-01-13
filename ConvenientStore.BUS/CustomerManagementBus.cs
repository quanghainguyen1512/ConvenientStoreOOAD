using ConvenientStore.DAO;
using ConvenientStore.DTO;
using ConvenientStore.Helpers.MappingHelper;
using ConvenientStore.Helpers.Message;
using ConvenientStore.Services.Interfaces;
using ConvenientStore.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.BUS
{
    public class CustomerManagementBus
    {
        private ICustomerRepository customerRepository;

        public CustomerManagementBus()
        {
            this.customerRepository = new CustomerRepository();
        }

        public List<CustomerManagementDto> GetAllCustomer()
        {
            List<CustomerManagementDto> customerManagementDtos = new List<CustomerManagementDto>();

            List<Customer> customers = null;

            try
            {
                customers = this.customerRepository.GetAll().ToList();
            }
            catch
            {
                return customerManagementDtos;
            }

            foreach(Customer customer in customers)
            {
                CustomerManagementDto dto = Mapping.Mapper.Map<CustomerManagementDto>(customer);
                customerManagementDtos.Add(dto);
            }

            return customerManagementDtos;
        }

        
        public List<CustomerManagementDto> GetCustomerByName(string name)
        {
            List<CustomerManagementDto> customerManagementDtos = new List<CustomerManagementDto>();

            List<Customer> customers = null;

            try
            {
                customers = this.customerRepository.GetByName(name);
            }
            catch
            {
                return customerManagementDtos;
            }

            foreach (Customer customer in customers)
            {
                CustomerManagementDto dto = new CustomerManagementDto();
                Console.WriteLine(customer.CusTypeId);
                customerManagementDtos.Add(dto);
            }

            return customerManagementDtos;
        }

        public CustomerManagementDto GetCustomerByPhone(string phone)
        {
            CustomerManagementDto dto;

            try
            {
                dto = Mapping.Mapper.Map<CustomerManagementDto>(this.customerRepository.GetByPhone(phone, true));
                dto.Message = "";
            } catch
            {
                dto = new CustomerManagementDto(MessageContent.GET_CUSTOMER_ERROR);
            }
            

            return dto;
        }
    }
}
