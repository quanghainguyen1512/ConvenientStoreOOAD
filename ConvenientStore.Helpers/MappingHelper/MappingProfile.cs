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
                    opt => opt.MapFrom(src => src.Gender == true ? "Nam" : "Nu"));
        }

        private int DateOfBirthToAge(DateTime dob)
        {
            var ts = DateTime.Now.Subtract(dob);            var tempDate = DateTime.MinValue.Add(ts);
            return tempDate.Year - 1;
        }
    }
}
