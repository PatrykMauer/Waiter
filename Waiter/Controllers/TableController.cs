using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Waiter.Services;
using Waiter.ViewModels;
using System;
using System.Web.UI.WebControls;

namespace Waiter.Controllers
{
    public class TableController : Controller
    {
        private readonly ITableService _tableService;

        public TableController(ITableService tableService)
        {
            _tableService = tableService;
        }
        // GET: Table
        [HttpPost]
        public async Task<ActionResult> Update(int selectedTable, int amount, string selectedDish, string price)
        {
            await _tableService.UpdateAsync(selectedTable, amount, selectedDish, Convert.ToDecimal(price.Replace("zł", "")));

            var table = await _tableService.GetAsync(selectedTable);
            var amounts = table.Orders.Select(x => x.Amount).ToList();
            var prices = table.Orders.Select(x => x.Price).ToList();
            decimal sum = 0;
            for (var i = 0; i < table.Orders.Count(); i++)
            {
                sum += amounts[i] * prices[i];
            }

            var viewModel = new OrderViewModel()
            {
                TableId = selectedTable,
                Orders = table.Orders,
                Sum = sum
            };

            return PartialView("_DisplayOrder", viewModel);
        }

        public async Task<ActionResult> Display()
        {
            var tables = await _tableService.GetAllAsync();

            var viewModel = new TablesViewModel()
            {
                Tables = tables,
            };

            return View(model: viewModel);
        }

        public async Task<ActionResult> Pay(int id)
        {
            var table = await _tableService.GetAsync(id);

            return View(table);
        }

        public async Task<ActionResult> Clear(int id)
        {
            await _tableService.RemoveAsync(id);

            return RedirectToAction("Display");
        }
    }
}