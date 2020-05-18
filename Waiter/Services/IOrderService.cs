using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waiter.Models;

namespace Waiter.Services
{
    public interface IOrderService : IService
    {
        Task<IEnumerable<Order>> GetAsync (int selectedTable);
        Task<IEnumerable<Order>> GetAllAsync();
        Task AddAsync(int selectedTable, int amount, string selectedDish, string price);
    }
}
