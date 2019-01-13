using ConvenientStore.Services.Interfaces;
using ConvenientStore.Services.Repositories;
using ConvenientStore.Helpers.MappingHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConvenientStore.DTO;
using System.Configuration;
using ConvenientStore.BUS;
using ConvenientStore.DAO;
using System.IO;

namespace DemoOnConsole
{
    class Program
    {
        private static string PATH_IMAGE = "D:\\GitHub\\ConvenientStoreOOAD\\Resource\\";

        static void Main(string[] args)
        {
            //IProductRepository productRepository = new ProductRepository();
            //Product product = productRepository.GetById(2);
            //Console.WriteLine(product.ImageUrl);
            //Console.ReadLine();

           // updateImageForProduct();
        }

        private static void updateImageForProduct()
        {
            for(int i = 2; i <= 20; i++)
            {
                IProductRepository productRepository = new ProductRepository();
                Product product = productRepository.GetById(i);

                var base64String = Convert.ToBase64String(File.ReadAllBytes(PATH_IMAGE + i + ".jpg"));
                product.ImageUrl = Convert.FromBase64String(base64String);

                productRepository.Update(product);
            }
        }
    }
}
