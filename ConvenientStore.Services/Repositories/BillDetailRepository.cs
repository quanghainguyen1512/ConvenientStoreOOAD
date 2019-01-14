using ConvenientStore.DAO;
using ConvenientStore.Services.Interfaces;
using Dapper;
using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.Services.Repositories
{
    public class BillDetailRepository : IBillDetailRepository
    {
        public bool Add(BillDetail obj)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                return con.Insert(obj) != 0;
            }
        }

        public bool AddRange(IEnumerable<BillDetail> objs)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BillDetail> GetAll()
        {
            using (var con = DbConnection.Instance.Connection)
            {
                return con.GetAll<BillDetail>();
            }
        }

        public IEnumerable<BillDetail> GetByBill(int billId)
        {
            using (var con = DbConnection.Instance.Connection)
            {
                var query = "select * from bill_detail where BillId = @billId";
                return con.Query<BillDetail>(query, param: new { billId });
            }
        }

        public BillDetail GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(BillDetail obj)
        {
            throw new NotImplementedException();
        }
    }
}
