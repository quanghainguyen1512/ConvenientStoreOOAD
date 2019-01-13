using ConvenientStore.DAO;
using ConvenientStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z.Dapper.Plus;

namespace ConvenientStore.Services.Repositories
{
    public class ComboRepository : IComboRepository
    {
        public bool Add(Combo obj)
        {
            throw new NotImplementedException();
        }

        public bool AddRange(IEnumerable<Combo> objs)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Combo> GetAll()
        {
            throw new NotImplementedException();
        }

        public Combo GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Combo obj)
        {
            throw new NotImplementedException();
        }
    }
}
