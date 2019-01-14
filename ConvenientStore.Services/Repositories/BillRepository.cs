using ConvenientStore.DAO;
using ConvenientStore.Services.Interfaces;
using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z.Dapper.Plus;

namespace ConvenientStore.Services.Repositories
{
    public class BillRepository : IBillRepository
    {
        public bool Add(Bill obj)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                //return con.Insert(obj) != 0;
                //con.Open();
                //DapperPlusManager.Entity<Bill>()
                //    .Table("bill")
                //    .Ignore(b => b.Customer)
                //    .Ignore(b => b.BillDetails);
                //DapperPlusManager.Entity<BillDetail>()
                //    .Table("bill_detail")
                //    .Ignore(bd => bd.ProductDetail)
                //    .Ignore(bd => bd.Bill)
                //    .Map(bd => new
                //    {
                //        bd.Bill.BillId,
                //        bd.ProductDetail.ProductDetailId
                //    });
                //using (var tran = con.BeginTransaction())
                //{
                //    try
                //    {
                //        tran.BulkInsert(obj)
                //            .ThenForEach(b => b.BillDetails.ForEach(bd => bd.Bill = b))
                //            .ThenBulkInsert(b => b.BillDetails);
                //    }
                //    catch (Exception e)
                //    {
                //        var a = e;
                //        tran.Rollback();
                //        return false;
                //    }
                //    tran.Commit();
                //    return true;
                //}

                return con.Insert(obj) == 1;
            }
        }

        public bool AddRange(IEnumerable<Bill> objs)
        {
            throw new NotImplementedException();
        }

        public int CountBill()
        {
            using (var con = DbConnection.Instance.Connection)
            {
                var query = "select max(BillId) from bill";
                return con.Query<int>(query).FirstOrDefault();
            }
        }

        public IEnumerable<Bill> GetAll()
        {
            using (var con = DbConnection.Instance.Connection)
            {

                return con.GetAll<Bill>();
            }
        }

        public IEnumerable<Bill> GetByCustomerId(int customerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Bill> GetByDateRange(DateTime start, DateTime end)
        {
            throw new NotImplementedException();
        }

        public Bill GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Bill GetByIdWithCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Bill obj)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                return con.Update(obj);
            }
        }
    }
}
