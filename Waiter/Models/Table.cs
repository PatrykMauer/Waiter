using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Waiter.Models
{
    public class Table
    {
        public int Id { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }

        public decimal TotalPrice()
        {
            var totalPrice=0M;
            foreach(var order in Orders)
            {
                totalPrice += order.CountPrice();
            }

            return totalPrice;
        }
    }
}