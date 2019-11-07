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
    public class DeleteModel : PageModel
    {
        private readonly IOrderLineService orderLineService;

        public OrderLine orderLines { get; set; }

        public DeleteModel(IOrderLineService orderLineService)
        {
            this.orderLineService = orderLineService;
        }
        public IActionResult OnGet(int orderlineId)
        {
            orderLines = orderLineService.GetOrderLine(orderlineId);

            if(orderLines != null)
            {
                return Page();
            } 
            else
            {
                return RedirectToPage("/OrderLines/Index");
            }
        }

        public IActionResult OnPost(int orderlineId)
        {
            var orderline = orderLineService.Delete(orderlineId);

            if (orderline != null)
            {
                orderLineService.Delete(orderlineId);
                TempData["Message"] = $"{orderline.Id} deleted";
            }

            return RedirectToPage("Index");
        }
    }
}
