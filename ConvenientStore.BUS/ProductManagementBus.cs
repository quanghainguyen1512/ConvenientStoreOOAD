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
    public class ProductManagementBus
    {
        private IProductRepository productRepository;
        private IProductDetailRepository productDetailRepository;


        public ProductManagementBus()
        {
            this.productDetailRepository = new ProductDetailRepository();
            this.productRepository = new ProductRepository();
        }

        public List<ProductMangementDto> GetAllProduct()
        {
            List<ProductMangementDto> dtos = new List<ProductMangementDto>();

            try
            {
                List<Product> products = this.productRepository.GetAll().ToList();

                foreach(Product pd in products)
                {
                    ProductMangementDto dto = new ProductMangementDto();
                    dto.Id = pd.ProductId.ToString();
                    dto.Barcode = pd.Barcode;
                    dto.Unit = pd.Unit;
                    dto.ProductName = pd.Name;
                    dto.ImageUrl = Convert.ToBase64String(pd.ImageUrl);
                    dto.Quantity = this.productDetailRepository.Quantity(Convert.ToInt32(dto.Id));

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
