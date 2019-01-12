using AutoMapper;

using ConvenientStore.DTO;
using ConvenientStore.DAO;

namespace ConvenientStore.Helpers.MappingHelper
{
    class MappingCustomerBill : Profile
    {
        public MappingCustomerBill()
        {
            CreateMap<Customer, CustomerBillDto>()
                .ForMember(dest => dest.Id,
                    opt => opt.MapFrom(src => src.CustomerId))
                .ForMember(dest => dest.FullName,
                    opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                .ForMember(dest => dest.PhoneNumer,
                    opt => opt.MapFrom(src => src.PhoneNumber));
        }
    }
}
