using ConvenientStore.DAO;
using ConvenientStore.Services.Interfaces;
using Dapper.Contrib.Extensions;
using Dapper.Mapper;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z.Dapper.Plus;

namespace ConvenientStore.Services.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        public bool Add(Order obj)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                con.Open();
                DapperPlusManager.Entity<Order>()
                    .Table("order")
                    .Identity(e => e.OrderId)
                    .Ignore(e => e.OrderDetails);
                DapperPlusManager.Entity<OrderDetail>()
                    .Table("order_detail")
                    .Identity(od => od.OrderDetailId)
                    .Ignore(od => od.Order)
                    .Ignore(od => od.Product);
                    //.Map(od => new
                    //{
                    //    od.Order.OrderId,
                    //    od.Product.ProductId
                    //});

                using (var tran = con.BeginTransaction())
                {
                    try
                    {
                        con.BulkInsert(obj)
                            .ThenForEach(o => o.OrderDetails.ForEach(od => od.OrderId = o.OrderId))
                            .ThenBulkInsert(o => o.OrderDetails);
                    }
                    catch (Exception e)
                    {
                        tran.Rollback();
                        return false;
                    }
                    tran.Commit();
                    return true;
                }
            }
        }

        public bool AddRange(IEnumerable<Order> objs)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAll()
        {
            using (var con = DbConnection.Instance.Connection)
            {
                return con.GetAll<Order>();
            }
        }

        public Order GetById(int id)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                var sql = "SELECT o.OrderId, o.OrderedDate, p.Barcode, p.Name, od.Quantity, od.Status " +
                    "FROM mrwhoami_OOAD.order as o " +
                    "INNER JOIN order_detail as od " +
                    "ON o.OrderId = od.OrderId " +
                    "INNER JOIN product as p " +
                    "ON p.ProductId = od.ProductId " +
                    "WHERE o.OrderId = @id";
                var dict = new Dictionary<int, Order>();

                var result = con.Query<Order, Product, OrderDetail, Order>(
                    sql,
                    param: new { id },
                    splitOn: "Barcode, Quantity",
                    map: (o, p, od) =>
                    {
                        od.Product = p;
                        if (!dict.TryGetValue(o.OrderId, out var entry))
                        {
                            entry = o;
                            entry.OrderDetails = new List<OrderDetail>();
                            dict.Add(entry.OrderId, entry);
                        }
                        entry.OrderDetails.Add(od);
                        return entry;
                    }).FirstOrDefault();
                return result;
            }
        }

        public bool Update(Order obj)
        {
            throw new NotImplementedException();
        }
    }
}
