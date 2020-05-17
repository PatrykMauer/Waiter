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
    public class HomeController : Controller
    {
        private readonly ITableRepository _tableRepository;

        public HomeController(ITableRepository tableRepository)
        {
            _tableRepository = tableRepository;
        }
        public async Task<ActionResult> Index()
        {
            var tables = await _tableRepository.GetAllAsync();

            var viewModel = new TablesViewModel()
            { 
                Tables = tables,
            };

            return View(viewModel);
        }
    }
}