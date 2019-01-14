using AutoMapper;
using ConvenientStore.DAO;
using ConvenientStore.DTO;
using System;

namespace ConvenientStore.Helpers.MappingHelper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerDto>()
                .ForMember(dest => dest.Age,
                    opt => opt.MapFrom(src => DateOfBirthToAge(src.DateOfBirth)))
                .ForMember(dest => dest.FullName,
                    opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                .ForMember(dest => dest.Gender,
                    opt => opt.MapFrom(src => src.Gender == true ? "Nam" : "Nu"))
                .ForMember(dest => dest.CustomerType,
                    opt => opt.MapFrom(src => src.CustomerType.Name));

            CreateMap<CustomerForOperationsDto, Customer>();

            CreateMap<Sale, DTO.Sale.SaleDto>()
                .ForMember(dest => dest.Status,
                    opt => opt.MapFrom(src => GetStatusFromDate(src.StartDate, src.EndDate)))
                .ForMember(dest => dest.TypeOfDiscount,
                    opt => opt.MapFrom(src => src.TypeOfDiscount ? "Voucher" : "Coupon"));

            CreateMap<DTO.Sale.SaleForOperationsDto, Sale>();

            CreateMap<Order, DTO.Order.OrderDto>();

            CreateMap<DTO.Order.OrderForOperationsDto, Order>();

            CreateMap<OrderDetail, DTO.Order.OrderDetailDto>()
                .ForMember(dest => dest.ProductName,
                    opt => opt.MapFrom(src => src.Product.Name))
                .ForMember(dest => dest.Barcode,
                    opt => opt.MapFrom(src => src.Product.Barcode))
                .ForMember(dest => dest.Status,
                    opt => opt.MapFrom(src => src.Status ? "Đã nhận" : "Đang chờ"));

            CreateMap<DTO.Order.OrderDetailForOperationsDto, OrderDetail>();
                            
            CreateMap<Customer, CustomerManagementDto>()
                .ForMember(dest => dest.Id,
                    opt => opt.MapFrom(src => src.CustomerId.ToString()))
                .ForMember(dest => dest.FirstName,
                    opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName,
                    opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.DateOfBirth,
                    opt => opt.MapFrom(src => src.DateOfBirth.ToShortDateString()))
                .ForMember(dest => dest.PhoneNumber,
                    opt => opt.MapFrom(src => src.PhoneNumber))
                .ForMember(dest => dest.Point,
                    opt => opt.MapFrom(src => src.Point.ToString()))
                .ForMember(dest => dest.Email,
                    opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Gender,
                    opt => opt.MapFrom(src => src.Gender ? "Nam" : "Nữ"))
                .ForMember(dest => dest.CusType,
                    opt => opt.MapFrom(src => src.CustomerType.Name));
        }

        private int DateOfBirthToAge(DateTime dob)
        {
            var ts = DateTime.Now.Subtract(dob);
            var tempDate = DateTime.MinValue.Add(ts);

            return tempDate.Year - 1;
        }

        private string GetStatusFromDate(DateTime start, DateTime end)
        {
            if (DateTime.Now < start)
                return "Sắp";
            else if (DateTime.Now > end)
                return "Đã kết thúc";
            else
                return "Đang chạy";
        }

    }
}
