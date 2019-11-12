using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodDemo.Core.ServiceInterface;
using FoodDemo.Data.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FoodDemo.Web.Pages.OrderLines
{
    public class DetailModel : PageModel
    {
        private readonly IOrderLineService orderLineService;
        private readonly IOrderService orderService;

        public IEnumerable<OrderLine> OrderLines { get; set; }
        public Order Orders { get; set; }
        public OrderLine OrderLine { get; set; }
        public int orderlineid { get; set; }

        public DetailModel(IOrderLineService orderLineService,IOrderService orderService)
        {
            this.orderLineService = orderLineService;
            this.orderService = orderService;
        }

        public IActionResult OnGet(int orderlineId)
        {
            this.orderlineid = orderlineId;
            OrderLines = orderLineService.GetOrderLine(orderlineId);
            Orders = orderService.GetOrder(orderlineId);

            if(OrderLines != null)
            {
                return Page();
            }
            else 
            {
                return NotFound();
            }
        }
    }
}