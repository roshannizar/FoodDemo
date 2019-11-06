using FoodDemo.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDemo.Core.ServiceInterface
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        Product GetProduct(int id);
        void Create(Product product);
        int Commit();
    }
}
