using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDemo.Core.ServiceInterface;
using FoodDemo.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodDemo.Web.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly IOrderService orderService;
        public IEnumerable<Order> Orders { get; set; }

        public IndexModel(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        public void OnGet()
        {
            Orders = orderService.GetOrders();
        }
    }
}