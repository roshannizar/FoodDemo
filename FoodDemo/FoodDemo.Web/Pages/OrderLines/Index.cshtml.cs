﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using FoodDemo.Core.ServiceInterface;
using FoodDemo.Data.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace FoodDemo.Web.Pages.OrderLines
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration configuration;
        private readonly IOrderLineService orderLineService;
        private readonly IProductService productService;
        private readonly ICustomerService customerService;
        public IEnumerable<OrderLine> OrderLines { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public SelectList CustomerList { get; set; }
        public SelectList ProductList { get; set; }
        [BindProperty]
        public OrderLine OrderLine { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Productname { get; set; }
        
        public IndexModel(IConfiguration configuration,IOrderLineService orderLineService,IProductService productService,ICustomerService customerService)
        {
            this.configuration = configuration;
            this.orderLineService = orderLineService;
            this.productService = productService;
            this.customerService = customerService;
        }

        public void OnGet()
        {
            //Customer dropdown
            var listOfCustomers = customerService.GetCustomers().ToList();
            CustomerList = new SelectList(listOfCustomers, "Id", "FirstName");

            var listOfProducts = productService.GetProducts().ToList();
            ProductList = new SelectList(listOfProducts, "Name", "Name");
        } 

        
    }
}