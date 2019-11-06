using FoodDemo.Core.ServiceInterface;
using FoodDemo.Data.Context;
using FoodDemo.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FoodDemo.Core.Services
{
    public class OrderService : IOrderService
    {
        private readonly FoodDbContext db;

        public OrderService(FoodDbContext db) 
        {
            this.db = db;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public void Create(Order order)
        {
            db.Add(order);
        }

        public IEnumerable<Order> GetOrders()
        {
            var query = from o in db.Orders
                   orderby o.Status
                   select o;
            return query;
        }
    }
}
