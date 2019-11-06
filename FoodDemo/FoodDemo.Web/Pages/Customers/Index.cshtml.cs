using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDemo.Core.ServiceInterface;
using FoodDemo.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace FoodDemo.Web.Pages.Customers
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration configuration;
        private readonly ICustomerService customerService;
        public IEnumerable<Customer> Customers { get; set; }
        [BindProperty]
        public Customer customer { get; set; }

        public IndexModel(IConfiguration Configuration,ICustomerService customerService)
        {
            configuration = Configuration;
            this.customerService = customerService;
        }

        public void OnGet()
        {
            Customers = customerService.GetCustomers();
        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                customerService.Create(customer);
                customerService.Commit();
            }

            return RedirectToPage("Index");
        }
    }
}
