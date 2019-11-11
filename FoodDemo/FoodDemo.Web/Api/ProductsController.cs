using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using FoodDemo.Data.Context;
using FoodDemo.Data.Entity;
using Microsoft.AspNetCore.Mvc;

namespace FoodDemo.Web.Api
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly FoodDbContext db;

        public ProductsController(FoodDbContext db)
        {
            this.db = db;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return from p in db.Products
                   select p;
        }

        // GET api/<controller>/bun
        [HttpGet("{name}")]
        public IEnumerable<Product> Get(string name)
        {
            return from p in db.Products
                   where p.Name == (name)
                   orderby p.Name
                   select p;
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<ActionResult<Product>> Post([FromBody]Product product)
        {
            db.Products.Add(product);
            await db.SaveChangesAsync();

            return product;
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
