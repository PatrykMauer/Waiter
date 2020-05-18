using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Waiter.Models;

namespace Waiter.Services
{
    public interface ITableService : IService
    {
        Task<Table> GetAsync(int tableId);
        Task<IEnumerable<Table>> GetAllAsync();
        Task UpdateAsync(int tableId, int amount, string dishName, decimal price);
        Task RemoveAsync(int tableId);
    }
}