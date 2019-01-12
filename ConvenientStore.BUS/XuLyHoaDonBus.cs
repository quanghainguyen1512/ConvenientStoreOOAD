using ConvenientStore.DAO;
using ConvenientStore.DTO;
using ConvenientStore.Services.Interfaces;
using ConvenientStore.Services.Repositories;
using System;
using ConvenientStore.Helpers.MappingHelper;

namespace ConvenientStore.BUS
{
    public class XuLyHoaDonBus
    {
        private ICustomerRepository customerRepository;
        private IProductRepository productRepository;

        public XuLyHoaDonBus()
        {
            this.customerRepository = new CustomerRepository();
            this.productRepository = new ProductRepository();
        }

        public CustomerBillDto GetCustomerByPhoneNumber(String phoneNumber)
        {
            CustomerBillDto dto = null;

            String message = this.validatePhoneNumber(phoneNumber);

            if(!"".Equals(message))
            {
                dto = new CustomerBillDto(message);
                return dto;
            }

            Customer customer = this.customerRepository.GetCustomerByPhoneNumber(phoneNumber);

            if(customer == null)
            {
                dto = new CustomerBillDto("Không tìm thấy dữ liệu khách hàng\r\nVui lòng nhập lại thông tin");
                return dto;
            }

            dto = Mapping.mapperCustomerBill.Map<CustomerBillDto>(customer);
            dto.Message = "";
            return dto;
        }

        private String validatePhoneNumber(String phoneNumber)
        {
            String result = "";



            return result;
        }
        
        public ProductBillDto GetProductByBarcode(String barcode)
        {
            ProductBillDto dto = null;

            Product product = this.productRepository.GetProductByBarcode(barcode);
            if(product == null)
            {
                dto = new ProductBillDto("Không tìm thấy dữ liệu sản phẩm\r\nVui lòng nhập lại");
                return dto;
            }

            return dto;
        }
    }
}
