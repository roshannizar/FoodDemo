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
    public class OrderDetailModel : PageModel
    {
        private readonly IOrderService orderService;
        private readonly IOrderLineService orderLineService;
        public OrderLine OrderLines { get; set; }

        public OrderDetailModel(IOrderService orderService, IOrderLineService orderLineService)
        {
            this.orderService = orderService;
            this.orderLineService = orderLineService;
        }

        public void OnGet()
        {

        }
    }
}