using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using System.Web;
using Waiter.Models;
using Waiter.Repositories;

namespace Waiter.Services
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
       

        public async Task<IEnumerable<Order>> GetAsync(int selectedTable)
        {
            var orders = await _orderRepository.GetAsync(selectedTable);

            return orders;
        }

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            var orders = await _orderRepository.GetAllAsync();

            return orders;
        }

        public async Task AddAsync(int selectedTable, int amount, string selectedDish, string price)
        {
            await Task.CompletedTask;

            return;
        }
    }
}