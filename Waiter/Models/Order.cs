using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Waiter.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int TableId { get; set; }
        public int OrderId { get; set; }
    }
}