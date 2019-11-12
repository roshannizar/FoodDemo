using FoodDemo.Core.ServiceInterface;
using FoodDemo.Data.Context;
using FoodDemo.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace FoodDemo.Core.Services
{
    public class OrderLineService : IOrderLineService
    {
        private readonly FoodDbContext db;

        public OrderLineService(FoodDbContext db)
        {
            this.db = db;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public void Create(OrderLine orderLine)
        {
            db.Add(orderLine);
        }

        public OrderLine Delete(int id)
        {
            var orderline = GetOrderLineById(id);

            if(orderline != null)
            {
                db.OrderLines.Remove(orderline);
            }

            return orderline;
        }

        public IEnumerable<OrderLine> GetOrderLine(int id)
        {
            var query = db.OrderLines.Include(p => p.Products).Include(o => o.Orders).Where(o => o.OrderId == id).ToList();
            return query;
        }

        public OrderLine GetOrderLineById(int id)
        {
            var query = db.OrderLines.Find(id);
            return query;
        }

        public IEnumerable<OrderLine> GetOrderLines()
        {
            //var query = (from o in db.OrderLines
            //             join p in db.Products on o.ProductId equals p.Id
            //             select new {o,p});

            var query = db.OrderLines.Include(p => p.Products).ToList();

            return query;
        }
    }
}
