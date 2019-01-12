using ConvenientStore.DAO;
using ConvenientStore.DTO;
using ConvenientStore.Helpers.MappingHelper;
using ConvenientStore.Services.Interfaces;
using ConvenientStore.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.BUS
{
    public class CustomerBus
    {
        private static readonly Lazy<CustomerBus> _lazy = new Lazy<CustomerBus>(() => new CustomerBus());

        private ICustomerRepository _cusRepo;

        public static CustomerBus Instance
        {
            get { return _lazy.Value; }
        }

        private CustomerBus()
        {
            _cusRepo = new CustomerRepository();
        }

        public CustomerDto GetCustomerById(int id)
        {
            var cusDao = _cusRepo.GetById(id);
            var cusDto = Mapping.Mapper.Map<CustomerDto>(cusDao);
            return cusDto;
        }

        public CustomerDto GetCustomerByPhone(string phone)
        {
            var cusDao = _cusRepo.GetByPhone(phone);
            var cusDto = Mapping.Mapper.Map<CustomerDto>(cusDao);
            return cusDto;
        }

        public bool AddCustomer(CustomerForOperationsDto customer)
        {
            var cusDao = Mapping.Mapper.Map<Customer>(customer);
            return _cusRepo.Add(cusDao);
        }

        //public bool DeleteCustomer(CustomerForOperationsDto customer)
        //{
        //    var cusDao = Mapping.Mapper.Map<Customer>(customer);
        //    return _cusRepo.DeleteCustomer(cusDao);
        //}

        public bool CheckPhoneNumberExists(string phone)
        {
            return _cusRepo.CheckPhoneNumberExists(phone);
        }
    }
}
