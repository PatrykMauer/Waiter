using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using Waiter.Models;

namespace Waiter.ViewModels
{
    public class TablesViewModel
    {
        public int TableId { get; set;}
        public IEnumerable<Table> Tables { get; set; }
    }
}