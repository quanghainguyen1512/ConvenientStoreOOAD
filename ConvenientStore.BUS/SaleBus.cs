using ConvenientStore.DAO;
using ConvenientStore.DTO;
using ConvenientStore.DTO.Sale;
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
    public class SaleBus
    {
        private static readonly Lazy<SaleBus> _lazy = new Lazy<SaleBus>(() => new SaleBus());

        private ISaleRepository _saleRepo;

        public static SaleBus Instance
        {
            get { return _lazy.Value; }
        }

        private SaleBus()
        {
            _saleRepo = new SaleRepository();
        }

        public IEnumerable<SaleDto> GetAllSales()
        {
            var sales = _saleRepo.GetAll();
            var result = Mapping.Mapper.Map<IEnumerable<SaleDto>>(sales);
            return result;
        }

        public SaleDto GetSaleById(int id, bool withType)
        {
            var sale = withType ? _saleRepo.GetByIdWithDetail(id) : _saleRepo.GetById(id);
            return Mapping.Mapper.Map<SaleDto>(sale);
        }

        public bool AddSale(SaleForOperationsDto saledto)
        {
            /// TODO: Add validation
            var saledao = Mapping.Mapper.Map<Sale>(saledto);    /// TODO: Add Mapping
            var res = _saleRepo.Add(saledao);
            return res;
        }
    }
}
