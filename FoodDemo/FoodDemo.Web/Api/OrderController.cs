using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDemo.Data.Context;
using FoodDemo.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FoodDemo.Web.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        private readonly FoodDbContext db;

        public OrderController(FoodDbContext db)
        {
            this.db = db;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            var query = db.Orders.Include(o => o.OrderLines).ToList();

            return query;
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<ActionResult<Order>> Post([FromBody]Order order)
        {
            db.Orders.Add(order);
            await db.SaveChangesAsync();

            return order;
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
