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
            var query = from o in db.Orders
                        select o;

            return query;
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<ActionResult<Order>> Post([FromBody]Order order)
        {
            if (order != null)
            {
                db.Orders.Add(order);
                await db.SaveChangesAsync();

                return Ok("Created Successfully");
            } else
            {
                return BadRequest("Order was missing some field's maybe");
            }

        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Order>> Delete(int id)
        {
            var order = await db.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            db.Orders.Remove(order);
            await db.SaveChangesAsync();

            return order;
        }
    }
}
