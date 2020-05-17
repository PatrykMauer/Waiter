using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace Waiter.ViewModels
{
    public class OrderViewModel
    {
        public int TableId {get;set;}
        public int Amount { get; set; }
        public string Dish { get; set; }
        public string Price { get; set; }

    }
}