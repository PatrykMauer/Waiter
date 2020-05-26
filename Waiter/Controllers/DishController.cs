using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Waiter.Repositories;
using Waiter.ViewModels;

namespace Waiter.Controllers
{
    public class DishController : Controller
    {
        private readonly IDishRepository _dishRepository;

        // GET: Dish
        public DishController(IDishRepository dishRepository)
        {
            _dishRepository = dishRepository;
        }
        public async Task<ActionResult> Display(int selectedTable)
        {
            var dishes = await _dishRepository.GetAllAsync();

            var viewModel = new DishesViewModel()
            {
                TableId = selectedTable,
                Dishes = dishes
            };

            return PartialView("_DisplayDishes", viewModel);
        }

        public async Task<ActionResult> Price (string selectedDish)
        {
            var dish = await _dishRepository.GetAsync(selectedDish);

            var viewModel = new PriceViewModel()
            {
                Price = dish.Price
            };

            return PartialView("_DisplayPrice", viewModel);
        }
    }
}