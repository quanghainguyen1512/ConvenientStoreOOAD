using AutoMapper;
using ConvenientStore.DAO;
using ConvenientStore.DTO;


namespace ConvenientStore.Helpers.MappingHelper
{
    public class MappingProductBill : Profile
    {
        public MappingProductBill()
        {
            CreateMap<Product, ProductBillDto>()
                .ForMember(dest => dest.Id,
                    opt => opt.MapFrom(src => src.ProductId))
                .ForMember(dest => dest.ProductName,
                    opt => opt.MapFrom(src => src.Name));
        }
    }
}
