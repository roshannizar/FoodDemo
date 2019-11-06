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
    public class IndexModel : PageModel
    {
        private readonly IOrderLineService orderLineService;
        public IEnumerable<OrderLine> orderLines { get; set; }

        public IndexModel(IOrderLineService orderLineService)
        {
            this.orderLineService = orderLineService;
        }

        public void OnGet()
        {

        }
    }
}