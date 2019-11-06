using FoodDemo.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDemo.Core.ServiceInterface
{
    public interface IOrderService
    {
        IEnumerable<Order> GetOrders();
        void Create(Order order);
        int Commit();
    }
}
