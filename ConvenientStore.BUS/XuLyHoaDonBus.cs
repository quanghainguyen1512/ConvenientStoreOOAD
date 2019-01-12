using ConvenientStore.DAO;
using ConvenientStore.DTO;
using ConvenientStore.Services.Interfaces;
using ConvenientStore.Services.Repositories;
using System;
using ConvenientStore.Helpers.MappingHelper;
using ConvenientStore.Helpers.Message;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConvenientStore.BUS
{
    public class XuLyHoaDonBus
    {
        private ICustomerRepository customerRepository;
        private IProductRepository productRepository;
        private IProductDetailRepository productDetailRepository;
        private IBillRepository billRepository;
        private IBillDetailRepository billDetailRepository;

        public XuLyHoaDonBus()
        {
            this.customerRepository = new CustomerRepository();
            this.productRepository = new ProductRepository();
            this.productDetailRepository = new ProductDetailRepository();
            this.billRepository = new BillRepository();
            this.billDetailRepository = new BillDetailRepository();
        }

        public CustomerBillDto GetCustomerByPhoneNumber(String phoneNumber)
        {
            CustomerBillDto dto = null;

            String message = this.validatePhoneNumber(phoneNumber);

            if (!"".Equals(message))
            {
                dto = new CustomerBillDto(message);
                return dto;
            }

            Customer customer = this.customerRepository.GetByPhone(phoneNumber, true);

            if (customer == null)
            {
                dto = new CustomerBillDto(MessageContent.GET_CUSTOMER_ERROR + "\r\n" + MessageContent.REQUIRE_REINPUT_FIELD);
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

            Product product = this.productRepository.GetByBarcode(barcode.Trim());

            if(product == null)
            {
                dto = new ProductBillDto(MessageContent.GET_PRODUCT_ERROR + "\r\n" + MessageContent.REQUIRE_REINPUT_FIELD);
                return dto;
            }

            ProductDetail productDetail = this.productDetailRepository.GetProductDetailByProductIdAndMinExpidationDate(product.ProductId);

            if(productDetail == null)
            {
                dto = new ProductBillDto(MessageContent.GET_PRODUCT_ERROR + "\r\n" + MessageContent.REQUIRE_REINPUT_FIELD);
                return dto;
            }

            dto = new ProductBillDto();

            dto.Id = product.ProductId.ToString();
            dto.ProductName = product.Name;
            dto.Price = productDetail.Price.ToString();
            dto.SellRate = "0";
            dto.Unit = product.Unit;
            dto.Message = "";
            dto.Barcode = product.Barcode;
            dto.DetailId = productDetail.ProductDetailId.ToString();
            return dto;
        }

        public string SubmitBill(List<ProductBillDto> productBillDtos, CustomerBillDto customerBillDto, string total)
        {
            string result = "";

            result += this.updateCustomerInfo(customerBillDto);

            result += this.updateProductDetail(productBillDtos);

            result += this.addBill(productBillDtos, customerBillDto, total);

            return result;
        }

        private string updateCustomerInfo(CustomerBillDto customerBillDto)
        {
            string result = "";

            if (customerBillDto != null)
            {
                Customer customer = this.customerRepository.GetByPhone(customerBillDto.PhoneNumer, true);

                if (customer == null)
                {
                    result += MessageContent.GET_CUSTOMER_ERROR + MessageContent.BREAK_LINE;
                }

                customer.Point = Convert.ToInt32(customerBillDto.Point);
                try
                {
                    this.customerRepository.Update(customer);
                }
                catch
                {
                    result += String.Format(MessageContent.UPDATE_CUSTOMER_INFO_ERROR, customerBillDto.FullName) + MessageContent.BREAK_LINE;
                }
            }

            return result;
        }

        private string updateProductDetail(List<ProductBillDto> productBillDtos)
        {
            string result = "";

            foreach (ProductBillDto dto in productBillDtos)
            {

                int quantity = Convert.ToInt32(dto.Quantity);

                do
                {
                    ProductDetail productDetail = this.productDetailRepository
                           .GetProductDetailByProductIdAndMinExpidationDate(Convert.ToInt32(dto.Id));

                    if (quantity > productDetail.Quantity)
                    {
                        quantity -= productDetail.Quantity;
                        productDetail.Quantity = 0;
                    }
                    else
                    {
                        productDetail.Quantity -= quantity;
                        quantity = 0;
                    }

                    try
                    {
                        this.productDetailRepository.Update(productDetail);
                    }
                    catch
                    {
                        result += String.Format(MessageContent.UPDATE_PRODUCT_DETAIL_ERROR, dto.ProductName) + MessageContent.BREAK_LINE;
                    }

                } while (quantity > 0);
            }

            return result;
        }

        private string addBill(List<ProductBillDto> productBillDtos, CustomerBillDto customerBillDto, string total)
        {
            string result = "";

            string billCode = "";

            try
            {
                billCode = this.GenerateBillCode();
            }
            catch
            {
                result += MessageContent.SYSTEM_ERROR + MessageContent.BREAK_LINE;
            }

            Bill bill = new Bill();
            bill.BillId = Convert.ToInt32(billCode);
            bill.CreateDate = DateTime.Now;
            bill.Total = Convert.ToInt32(Regex.Replace(total, "[^.0-9]", ""));

            bill.BillDetails = new List<BillDetail>();

            if(customerBillDto != null)
            {
                Customer customer = this.customerRepository.GetById(Convert.ToInt32(customerBillDto.Id));
                bill.Customer = customer;
                bill.CustomerId = Convert.ToInt32(customerBillDto.Id);
            }

            this.billRepository.Add(bill);

            foreach (ProductBillDto dto in productBillDtos)
            {
                BillDetail billDetail = new BillDetail();
                billDetail.Quantity = Convert.ToInt32(dto.Quantity);

                billDetail.ProductDetailId = Convert.ToInt32(dto.DetailId);
                billDetail.BillId = Convert.ToInt32(bill.BillId);

                this.billDetailRepository.Add(billDetail);
            }

            

            return result;
        }

        public string GenerateBillCode()
        {
            return (this.billRepository.CountBill() + 1).ToString("000000");
        }

        public void ExportPdf(System.Collections.Generic.List<ProductBillDto> productBillDtos, CustomerBillDto customerBillDto)
        {

        }


    }
}
