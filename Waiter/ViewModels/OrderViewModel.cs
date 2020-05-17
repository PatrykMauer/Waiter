using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using Waiter.Models;

namespace Waiter.ViewModels
{
    public class OrderViewModel
    {
        public IEnumerable<Order> Orders { get; set; }
        public decimal Sum { get; set; }
    }
}