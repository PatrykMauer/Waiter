using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Waiter.ViewModels;

namespace Waiter.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public async Task<ActionResult> AddOrder(int selectedTable, int amount, string selectedDish, string price)
        {
            var viewModel = new OrderViewModel()
            {
                TableId = selectedTable,
                Amount = amount,
                Dish = selectedDish,
                Price = price,
            };    

            return PartialView("_DisplayOrder", viewModel);
        }
    }
}