using FoodDemo.Core.ServiceInterface;
using FoodDemo.Data.Context;
using FoodDemo.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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

        public Order GetOrder(int id)
        {
            var query = db.Orders.Find(id);

            return query;
        }

        public IEnumerable<Order> GetOrders()
        {
            var query = db.Orders.Include(c => c.Customers).ToList();
            return query;
        }
    }
}
