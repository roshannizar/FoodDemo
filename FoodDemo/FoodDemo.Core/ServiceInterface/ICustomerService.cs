using FoodDemo.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDemo.Core.ServiceInterface
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetCustomers();
        void Create(Customer customer);
        int Commit();
    }
}
