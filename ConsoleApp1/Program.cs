using ConvenientStore.BUS;
using ConvenientStore.DAO;
using ConvenientStore.DTO.Order;
using ConvenientStore.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var order = new OrderForOperationsDto()
            //{
            //    OrderedDate = DateTime.Now.AddMinutes(-2),
            //    OrderDetails = new List<OrderDetailForOperationsDto>()
            //    {
            //        new OrderDetailForOperationsDto
            //        {
            //            Quantity = 15,
            //            ProductId = 3
            //        },
            //        new OrderDetailForOperationsDto
            //        {
            //            Quantity = 10,
            //            ProductId = 2
            //        }
            //    }
            //};
            //var (r, m) = OrderBus.Instance.AddOrder(order);
            //Console.WriteLine(m);
            var a = OrderBus.Instance.GetOrderById(3);
            Console.WriteLine(a);
        }
    }
}
