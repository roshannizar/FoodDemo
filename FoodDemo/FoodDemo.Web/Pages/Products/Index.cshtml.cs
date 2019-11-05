using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDemo.Core.ServiceInterface;
using FoodDemo.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace FoodDemo.Web.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration configuration;
        private readonly IProductService productService;
        public IEnumerable<Product> Products { get; set; }

        public IndexModel(IConfiguration configuration,IProductService productService)
        {
            this.configuration = configuration;
            this.productService = productService;
        }
        public void OnGet()
        {
            Products = productService.GetAll();
        }
    }
}