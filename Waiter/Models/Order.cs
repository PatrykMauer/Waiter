using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Waiter.Models
{
    public class Order
    {
        public int TableId { get; protected set; } 
        public int Amount { get; protected set; }
        public string DishName { get; protected set; }
        public decimal Price { get; protected set; }

        public Order(int tableId, int amount, string dishName, decimal price)
        {
            TableId = tableId;
            Amount = amount;
            DishName = dishName;
            Price = price;
        }

        public decimal CountPrice()
        {
            return Amount * Price;
        }
    }
}