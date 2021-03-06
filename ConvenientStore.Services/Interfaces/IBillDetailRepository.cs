﻿using ConvenientStore.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.Services.Interfaces
{
    public interface IBillDetailRepository : IRepository<BillDetail>
    {
        IEnumerable<BillDetail> GetByBill(int billId);
    }
}
