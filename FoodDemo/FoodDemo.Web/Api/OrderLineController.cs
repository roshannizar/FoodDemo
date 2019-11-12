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
    public class OrderLineController : Controller
    {
        private readonly FoodDbContext db;

        public OrderLineController(FoodDbContext db)
        {
            this.db = db;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<OrderLine> Get()
        {
            var query = db.OrderLines.Include(p => p.Products).ToList();

            return query;
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<ActionResult<OrderLine>> Post([FromBody]OrderLine OrderLines)
        {
            db.OrderLines.Add(OrderLines);
            await db.SaveChangesAsync();

            return OrderLines;
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
