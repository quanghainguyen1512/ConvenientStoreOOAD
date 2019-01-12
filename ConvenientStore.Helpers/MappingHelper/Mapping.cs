using AutoMapper;
using System;

namespace ConvenientStore.Helpers.MappingHelper
{
    public class Mapping
    {
        private static readonly Lazy<IMapper> _lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<MappingProfile>();
            });
            return config.CreateMapper();
        });

        private static readonly Lazy<IMapper> _lazyCustomerBill = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<MappingCustomerBill>();
            });
            return config.CreateMapper();
        });

        private static readonly Lazy<IMapper> _lazyProductBill = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<MappingProductBill>();
            });
            return config.CreateMapper();
        });

        public static IMapper Mapper => _lazy.Value;

        public static IMapper mapperCustomerBill => _lazyCustomerBill.Value;

        public static IMapper mapperProductBill => _lazyProductBill.Value;
    }
}
