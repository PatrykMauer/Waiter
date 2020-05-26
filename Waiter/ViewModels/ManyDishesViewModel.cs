using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Waiter.Models;
    

namespace Waiter.ViewModels
{
    public class ManyDishesViewModel
    {
        public int DishId { get; set; }
        public int[] TableIds { get; set; }
        public IEnumerable<Dish> Dishes { get; set; }
    }
}