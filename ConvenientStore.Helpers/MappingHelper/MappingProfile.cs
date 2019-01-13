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
    }
}
