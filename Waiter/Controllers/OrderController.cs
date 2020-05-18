using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Waiter.Models;
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
        //public async Task<ActionResult> AddOrder(int selectedTable, int amount, string selectedDish, string price)
        //{

        //    await _orderService.AddAsync(selectedTable, amount, selectedDish, price);
        //    var orders = await _orderService.GetAsync(selectedTable);

        //    var amounts = orders.Select(x => x.Amount).ToList();
        //    var prices = orders.Select(x => x.Price).ToList();
        //    decimal sum = 0;
        //    for (var i = 0; i < orders.Count(); i++)
        //    {
        //        sum += amounts[i] * prices[i];
        //    }

        //    var viewModel = new OrderViewModel()
        //    {
        //        Orders = orders,
        //        Sum = sum
        //    };

        //    return PartialView("_DisplayOrder", viewModel);
        //}

        //public async Task<ActionResult> Display()
        //{
        //    var orders = await _orderService.GetAllAsync();

        //    var amounts = orders.Select(x => x.Amount).ToList();
        //    var prices = orders.Select(x => x.Price).ToList();
        //    decimal sum = 0;
        //    for (var i = 0; i < orders.Count(); i++)
        //    {
        //        sum += amounts[i] * prices[i];
        //    }

        //    var viewModel = new OrderViewModel()
        //    {
        //        Orders = orders,
        //        Sum = sum
        //    };

        //    return View("Order", viewModel);
        //}
    }
}