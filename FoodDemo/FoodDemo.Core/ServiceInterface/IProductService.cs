using FoodDemo.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDemo.Core.ServiceInterface
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        void AddProduct(Product product);
        int Commit();
    }
}
