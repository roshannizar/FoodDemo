using FoodDemo.Core.ServiceInterface;
using FoodDemo.Data.Context;
using FoodDemo.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodDemo.Core.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly FoodDbContext db;

        public CustomerService(FoodDbContext db)
        {
            this.db = db;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public void Create(Customer customer)
        {
            db.Add(customer);
        }

        public Customer GetCustomer(int id)
        {
            var query = db.Customers.Find(id);

            return query;
        }

        public IEnumerable<Customer> GetCustomers()
        {
            var query = from c in db.Customers
                   orderby c.FirstName
                   select c;

            return query;
        }
    }
}
