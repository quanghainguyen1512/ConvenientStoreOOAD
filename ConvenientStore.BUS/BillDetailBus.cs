using ConvenientStore.DAO;
using ConvenientStore.DTO;
using ConvenientStore.Services.Interfaces;
using ConvenientStore.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.BUS
{
    
    public class BillDetailBus
    {
        private IBillDetailRepository billDetailRepository;
        private IProductDetailRepository productDetailRepository;
        private IProductRepository productRepository;

        public BillDetailBus()
        {
            this.billDetailRepository = new BillDetailRepository();
            this.productDetailRepository = new ProductDetailRepository();
            this.productRepository = new ProductRepository();
        }

        public List<BillDetailDto> GetAllBillDetail(int billId)
        {
            List<BillDetailDto> billDetailDtos = new List<BillDetailDto>();

            try
            {
                List<BillDetail> billDetails = this.billDetailRepository.GetByBill(billId).ToList();

                foreach(BillDetail db in billDetails)
                {
                    BillDetailDto dto = new BillDetailDto();
                    dto.Id = db.BillDetailId.ToString();
                    dto.Quantity = db.Quantity.ToString();
                    dto.Sale = "";

                    int productDetailId = db.ProductDetailId;

                    ProductDetail productDetail = this.productDetailRepository.GetById(productDetailId);
                    dto.ProductCode = productDetail.GeneratedCode;
                    dto.Price = productDetail.Price.ToString("#,#", CultureInfo.InvariantCulture);

                    Product product = this.productRepository.GetById(productDetail.ProductId);
                    dto.ProduceName = product.Name;
                    dto.Unit = product.Unit;

                    dto.Total = (Convert.ToInt32(dto.Quantity) * Convert.ToInt32(dto.Price.Replace(",",""))).ToString("#,#", CultureInfo.InvariantCulture);

                    billDetailDtos.Add(dto);
                   
                }
        }
            catch
            {
                return billDetailDtos;
            }

            return billDetailDtos;
        }
    }
}
