using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Waiter.Models;
using Waiter.Repositories;

namespace Waiter.Services
{
    public class TableService : ITableService
    {
        private readonly ITableRepository _tableRepository;

        public TableService(ITableRepository tableRepository)
        {
            _tableRepository = tableRepository;
        }

        public async Task<IEnumerable<Table>> GetAllAsync()
            => await _tableRepository.GetAllAsync();

        public async Task<Table> GetAsync(int tableId)
            => await _tableRepository.GetAsync(tableId);

        public async Task UpdateAsync(int tableId, int amount, string dishName, decimal price)
        {
            var table = await _tableRepository.GetAsync(tableId);

            var order = new Order(tableId, amount, dishName, price);
            
            if (table.Orders.Any(x=>x.DishName.Contains(dishName)))
            {
                order = table.Orders.First(x=>x.DishName.Contains(dishName));
                table.RemoveOrder(order);
                order.IncrementAmount(amount);
            }

                table.AddOrder(order);
           
            await _tableRepository.UpdateAsync(table);
        }

        public async Task UpdateManyAsync(int[] selectedTables, int amount, string dishName, decimal price)
        {
            foreach(var id in selectedTables)
            {
                var table = await _tableRepository.GetAsync(id);

                var order = new Order(id, amount, dishName, price);

                if (table.Orders.Any(x => x.DishName.Contains(dishName)))
                {
                    order = table.Orders.First(x => x.DishName.Contains(dishName));
                    table.RemoveOrder(order);
                    order.IncrementAmount(amount);
                }

                table.AddOrder(order);

                await _tableRepository.UpdateAsync(table);
            }
        }

        public async Task RemoveAsync(int tableId,int amount, string dishName)
        {
            var table = await _tableRepository.GetAsync(tableId);

            if (table.Orders.Any(x => x.DishName.Contains(dishName)))
            {
                var order = table.Orders.First(x => x.DishName.Contains(dishName));
                table.RemoveOrder(order);
                
                order.DecrementAmount(amount);
                table.AddOrder(order);
            }

            await _tableRepository.UpdateAsync(table);
        }

        public async Task RemoveAllAsync(int tableId)
        {
            var table = await _tableRepository.GetAsync(tableId);

            table.Orders.Clear();

            await _tableRepository.UpdateAsync(table);
        }
    }
}