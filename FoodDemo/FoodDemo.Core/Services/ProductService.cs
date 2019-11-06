using FoodDemo.Core.ServiceInterface;
using FoodDemo.Data.Context;
using FoodDemo.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FoodDemo.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly FoodDbContext db;

        public ProductService(FoodDbContext db)
        {
            this.db = db;
        }

        public void Create(Product product)
        {
            db.Add(product);
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public IEnumerable<Product> GetProducts()
        {
            var query = from r in db.Products
                   orderby r.Name
                   select r;

            return query;
        }
    }
}
