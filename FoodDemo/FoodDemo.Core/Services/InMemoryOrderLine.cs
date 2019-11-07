using FoodDemo.Core.ServiceInterface;
using FoodDemo.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace FoodDemo.Core.Services
{
    public class InMemoryOrderLine : IOrderLineService
    {
        public List<OrderLine> orderLines { get; set; }
        public List<Product> products { get; set; }

        public InMemoryOrderLine()
        {
            orderLines = new List<OrderLine>()
            {
                new OrderLine{Id=1,ProductId=1,Quantity=2,UnitPrice=22,Status=StatusType.Pending }
            };
        }

        public int Commit()
        {
            return 0;
        }

        public void Create(OrderLine orderLine)
        {
            orderLines.Add(orderLine);
            orderLine.Id = orderLines.Max(ol => ol.Id)+1;
        }

        public OrderLine GetOrderLine(int id)
        {
            return orderLines.SingleOrDefault(o => o.Id == id);
        }

        public IEnumerable<OrderLine> GetOrderLines()
        {
            //var qry = from o in orderLines
            //          join p in products on o.ProductId equals p.Id
            //          select new { o, p };

            var qry = from o in orderLines
                      select o;


            return (IEnumerable<OrderLine>)qry;
        }

        public OrderLine Delete(int id)
        {
            var orderline = orderLines.FirstOrDefault(o => o.Id == id);

            if(orderline != null)
            {
                orderLines.Remove(orderline);
            }

            return orderline;
        }
    }
}
