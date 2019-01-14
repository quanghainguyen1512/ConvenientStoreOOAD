using ConvenientStore.DAO;
using ConvenientStore.DTO.Order;
using ConvenientStore.Helpers.MappingHelper;
using ConvenientStore.Services.Interfaces;
using ConvenientStore.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.BUS
{
    public class OrderBus
    {
        private static readonly Lazy<OrderBus> _lazy = new Lazy<OrderBus>(() => new OrderBus());

        private IOrderRepository _repo;

        private OrderBus()
        {
            _repo = new OrderRepository();
        }

        public static OrderBus Instance
        {
            get { return _lazy.Value; }
        }

        public (bool, string) AddOrder(OrderForOperationsDto orderdto)
        {
            var (isvalid, message) = orderdto.Validate();
            if (!isvalid)
                return (false, message.FirstOrDefault().ToString());
            try
            {
                var orderdao = Mapping.Mapper.Map<Order>(orderdto);
                var res = _repo.Add(orderdao);
                return (res, res ? "Đặt hàng thành công" : "Đã có lỗi xảy ra (CSDL)");
            }
            catch
            {
                return (false, "Mapping Failed");
            }
        }

        public IEnumerable<OrderDto> GetOrders()
        {
            var orders = _repo.GetAll();
            try
            {
                var result = Mapping.Mapper.Map<IEnumerable<OrderDto>>(orders);
                return result;
            }
            catch
            {
                return null;
            }
        }

        public OrderDto GetOrderById(int id)
        {
            var order = _repo.GetById(id);
            try
            {
                var result = Mapping.Mapper.Map<OrderDto>(order);
                return result;
            }
            catch
            {
                return null;
            }
        }
    }
}
