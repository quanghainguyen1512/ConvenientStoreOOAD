using ConvenientStore.DAO;
using ConvenientStore.DTO;
using ConvenientStore.Services.Interfaces;
using ConvenientStore.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.BUS
{
    public class BillManagementBus
    {
        private IBillRepository billRepository;
        private ICustomerRepository customerRepository;

        public BillManagementBus()
        {
            this.billRepository = new BillRepository();
            this.customerRepository = new CustomerRepository();
        }
        public List<BillManagementDto> GetAllBill()
        {
            List<BillManagementDto> dtos = new List<BillManagementDto>();

            try
            {
                List<Bill> bills = this.billRepository.GetAll().ToList();

                foreach (Bill b in bills)
                {
                    BillManagementDto dto = new BillManagementDto();
                    dto.Id = b.BillId.ToString();
                    dto.CreateDate = b.CreateDate.ToString("dd/MM/yyyy");
                    dto.Total = b.Total.ToString("#,#", CultureInfo.InvariantCulture);

                    int customerId = b.CustomerId;
                    if(customerId == 5)
                    {
                        dto.CustomerName = "";
                    }
                    else
                    {
                        Customer customer = this.customerRepository.GetById(customerId);
                        dto.CustomerName = customer.FirstName + " " + customer.LastName;
                    }

                    dtos.Add(dto);
                }
            }
            catch
            {
                return dtos;
            }

            return dtos;
        }
    }
}
