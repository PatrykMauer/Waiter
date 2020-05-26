using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Waiter.Models;

namespace Waiter.ViewModels
{
    public class EditViewModel
    {
        public int TableId { get; set; }
        public int DishId { get; set; }
        public IEnumerable<Dish> Dishes { get; set; }
    }
}