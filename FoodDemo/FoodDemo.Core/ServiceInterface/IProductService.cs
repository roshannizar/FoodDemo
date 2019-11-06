using FoodDemo.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDemo.Core.ServiceInterface
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        void Create(Product product);
        int Commit();
    }
}
