using AutoMapper;
using ConvenientStore.DAO;
using ConvenientStore.DTO;
using ConvenientStore.DTO.Sale;
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

            CreateMap<Sale, SaleDto>()
                .ForMember(dest => dest.Status,
                    opt => opt.MapFrom(src => GetStatusFromDate(src.StartDate, src.EndDate)))
                .ForMember(dest => dest.TypeOfDiscount,
                    opt => opt.MapFrom(src => src.TypeOfDiscount ? "Voucher" : "Coupon"));

            //CreateMap<SaleForOperations, Sale>()
                
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
