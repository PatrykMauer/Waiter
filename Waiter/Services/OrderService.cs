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
        public async Task AddAsync(int selectedTable, int amount, string selectedDish, string price)
        {
            var order = new Order()
            {
                TableIds = new List<int>() { selectedTable },
                Amount = amount,
                DishName = selectedDish,
                Price = Convert.ToDecimal(price.Replace("zł",""))
            };

            await _orderRepository.AddAsync(order);

            return;
        }

        public async Task<IEnumerable<Order>> GetAsync(int selectedTable)
        {
            var orders = await _orderRepository.GetAsync(selectedTable);

            return orders;
        }
    }
}