using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waiter.Models;

namespace Waiter.Repositories
{
    public interface IOrderRepository : IRepository
    {
        Task<IEnumerable<Order>> GetAsync(int id);
        Task AddAsync(Order order);
        Task UpdateAsync(Order order);
        Task RemoveAsync(int id);
    }
}
