using ConvenientStore.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.Services.Interfaces
{
    public interface IBillRepository : IRepository<Bill>
    {
        IEnumerable<Bill> GetByDateRange(DateTime start, DateTime end);
        IEnumerable<Bill> GetByCustomerId(int customerId);
        Bill GetByIdWithCustomer(int id);
        int CountBill();
    }
}
