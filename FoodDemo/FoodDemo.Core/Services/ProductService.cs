using FoodDemo.Core.ServiceInterface;
using FoodDemo.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDemo.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductService productService;

        public ProductService(IProductService productService)
        {
            this.productService = productService;
        }

        public void AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
