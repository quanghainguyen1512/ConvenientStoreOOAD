using ConvenientStore.DAO;
using ConvenientStore.DTO;
using ConvenientStore.Services.Interfaces;
using ConvenientStore.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvenientStore.BUS
{
    public class ProductManagementDetailBus
    {
        private IProductDetailRepository productDetailRepository;

        public ProductManagementDetailBus()
        {
            this.productDetailRepository = new ProductDetailRepository();
        }

        public List<ProductManagementDetailDto> GetProductDetailByProduct(int productId)
        {
            List<ProductManagementDetailDto> dtos = new List<ProductManagementDetailDto>();

            try
            {
                List<ProductDetail> productDetails = this.productDetailRepository.GetProductDetailByProduct(productId);

                foreach(ProductDetail pd in productDetails)
                {
                    ProductManagementDetailDto dto = new ProductManagementDetailDto();
                    dto.GeneratedCode = pd.GeneratedCode;
                    dto.Quantity = pd.Quantity.ToString();
                    dto.Price = pd.Price.ToString();
                    dto.ExpirationDate = pd.ExpirationDate.ToString("dd/MM/yyyy");
                    dtos.Add(dto);
                }
            }
            catch
            {
                return dtos;
            }

            return dtos;
        }
    }
}
