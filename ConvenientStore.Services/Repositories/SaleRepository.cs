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
    public class SaleRepository : ISaleRepository
    {
        public bool Add(Sale obj)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                con.Open();
                using (var tran = con.BeginTransaction())
                {
                    DapperPlusManager.Entity<Sale>()
                        .Table("sale")
                        .Identity(s => s.SaleId)
                        .Ignore(s => s.SaleToCustomerTypes);
                    DapperPlusManager.Entity<SaleToCustomerType>()
                        .Table("sale_to_customer_type")
                        .Ignore(sc => sc.CustomerType)
                        .Ignore(sc => sc.Sale)
                        .Map(sc => new
                        {
                            sc.Sale.SaleId,
                            CustomerTypeId = sc.CustomerType.TypeId
                        });
                    //DapperPlusManager.Entity<SaleToProduct>()
                    //    .Table("sale_to_products")
                    //    .Ignore(sp => sp.Sale)
                    //    .Ignore(sp => sp.Product)
                    //    .Map(sp => new
                    //    {
                    //        sp.Sale.SaleId,
                    //        sp.Product.ProductId
                    //    });
                    try
                    {
                        tran.BulkInsert(obj)
                            .ThenForEach(s => s.SaleToCustomerTypes.ForEach(sc => sc.Sale = s))
                            .ThenBulkInsert(s => s.SaleToCustomerTypes);
                    }
                    catch (Exception e)
                    {
                        tran.Rollback();
                        Console.WriteLine(e.Message);
                        return false;
                    }
                    tran.Commit();
                    return true;
                }
            }
        }

        public bool AddRange(IEnumerable<Sale> objs)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sale> GetAll()
        {
            using (var con = DbConnection.Instance.Connection)
            {
                return con.GetAll<Sale>();
            }
        }

        public Sale GetById(int id)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                return con.Get<Sale>(id);
            }
        }

        public Sale GetByIdWithDetail(int id)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                var sql = "SELECT s.SaleId, s.ShortName, s.Value, s.ConditionMin, s.TypeOfDiscount, s.StartDate, " +
                    "s.EndDate, s.Description, ct.TypeId, ct.Name " +
                    "FROM sale AS s " +
                    "INNER JOIN sale_to_customer_type as sc " +
                    "ON s.SaleId = sc.SaleId " +
                    "INNER JOIN customer_type AS ct " +
                    "ON ct.TypeId = sc.CustomerTypeId " +
                    "WHERE s.SaleId = @id";

                var dict = new Dictionary<int, Sale>();

                return con.Query<Sale, CustomerType, Sale>(sql,
                    param: new { id },
                    splitOn: "SaleId, TypeId",
                    map: (s, c) =>
                    {
                        var sc = new SaleToCustomerType
                        {
                            Sale = s,
                            CustomerType = c
                        };
                        var entry = new Sale();
                        if (!dict.TryGetValue(s.SaleId, out entry))
                        {
                            entry = s;
                            entry.SaleToCustomerTypes = new List<SaleToCustomerType>();
                            dict.Add(entry.SaleId, entry);
                        }
                        entry.SaleToCustomerTypes.Add(sc);
                        return entry;
                    }
                    ).FirstOrDefault();
            }
        }

        public bool Update(Sale obj)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                return con.Update(obj);
            }
        }
    }
}
