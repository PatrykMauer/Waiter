﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Waiter.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<int> TableIds { get; set; } = new List<int>();
        public int Amount { get; set; }
        public string DishName { get; set; }

        public decimal Price { get; set; }
    }
}