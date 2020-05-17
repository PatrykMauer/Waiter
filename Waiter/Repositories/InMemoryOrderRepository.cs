using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Waiter.Models;

namespace Waiter.Repositories
{
    public class InMemoryOrderRepository : IOrderRepository
    {
        private static ISet<Order> _orders = new HashSet<Order>();
        

        public async Task<IEnumerable<Order>> GetAsync(int tableId)
             => await Task.FromResult(_orders.Where(x => x.TableIds.Contains(tableId)).ToList());
        public async Task<IEnumerable<Order>> GetAllAsync()
            => await Task.FromResult(_orders);

        public async Task AddAsync(Order order)
        {
            await Task.FromResult(_orders.Add(order));
        }

        public async Task UpdateAsync(Order order)
        {
            var oldOrder = _orders.SingleOrDefault(x => x.Id == order.Id);
            await Task.CompletedTask;
        }

        public async Task RemoveAsync(int id)
        => await Task.FromResult(_orders.Remove(_orders.Single(x => x.Id == id)));

    }
}
