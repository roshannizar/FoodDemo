
using FoodDemo.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodDemo.Data.Context
{
    public class FoodDbContext: DbContext
    {
        public FoodDbContext(DbContextOptions<FoodDbContext> options):base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
