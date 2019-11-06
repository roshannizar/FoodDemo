using FoodDemo.Core.ServiceInterface;
using FoodDemo.Data.Context;
using FoodDemo.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public OrderLine GetOrderLine(int id)
        {
            var query = db.OrderLines.Find(id);
            return query;
        }

        public IEnumerable<OrderLine> GetOrderLines()
        {
            var query = from ol in db.OrderLines
                   orderby ol.Status
                   select ol;

            return query;
        }
    }
}
