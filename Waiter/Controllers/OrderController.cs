using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Waiter.Repositories;
using Waiter.Services;
using Waiter.ViewModels;

namespace Waiter.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        // GET: Order
        public async Task<ActionResult> AddOrder(int selectedTable, int amount, string selectedDish, string price)
        {

            await _orderService.AddAsync(selectedTable, amount, selectedDish, price);
            var orders = await _orderService.GetAsync(selectedTable);

            var viewModel = new OrderViewModel()
            {
               Orders=orders
            };    

            return PartialView("_DisplayOrder", viewModel);
        }
    }
}