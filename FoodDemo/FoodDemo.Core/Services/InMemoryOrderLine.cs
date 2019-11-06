using FoodDemo.Core.ServiceInterface;
using FoodDemo.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FoodDemo.Core.Services
{
    public class InMemoryOrderLine : IOrderLineService
    {
        public List<OrderLine> OrderLines { get; set; }

        public InMemoryOrderLine()
        {

        }

        public int Commit()
        {
            return 1;
        }

        public void Create(OrderLine orderLine)
        {
            OrderLines.Add(orderLine);
            orderLine.Id = OrderLines.Max(ol => ol.Id);        }

        public OrderLine GetOrderLine(int id)
        {
            return OrderLines.FirstOrDefault(ol => ol.Id == id);
        }

        public IEnumerable<OrderLine> GetOrderLines()
        {
            return from ol in OrderLines
                   orderby ol.Status
                   select ol;
        }
    }
}
