using FoodDemo.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDemo.Core.ServiceInterface
{
    public interface IOrderLineService
    {
        IEnumerable<OrderLine> GetOrderLines();
        IEnumerable<OrderLine> GetOrderLine(int id);
        OrderLine GetOrderLineById(int id);
        void Create(OrderLine orderLine);
        OrderLine Delete(int id);
        int Commit();
    }
}
