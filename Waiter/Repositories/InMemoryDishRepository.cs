using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Waiter.Models;

namespace Waiter.Repositories
{
    public class InMemoryDishRepository : IDishRepository
    {
        private static ISet<Dish> _dishes = new HashSet<Dish>()
        {
            new Dish {Id =1, Name = "CAPRICCIOSA", Price = 28.99M},
            new Dish {Id =2, Name = "CARBONARA", Price = 28.99M},
            new Dish {Id =3, Name = "CLASSICA", Price = 26.99M},
            new Dish {Id =4, Name = "EUROPEAN", Price = 28.99M},
            new Dish {Id =5, Name = "FARMER", Price = 2.99M},
        };

        public async Task<IEnumerable<Dish>> GetAllAsync()
            => await Task.FromResult(_dishes);


        public async Task<Dish> GetAsync(int id)
            => await Task.FromResult(_dishes.SingleOrDefault(x => x.Id == id));

        public async Task<Dish> GetAsync(string name)
            => await Task.FromResult(_dishes.SingleOrDefault(x => x.Name == name));


        public async Task AddAsync(Dish dish)
        {
            _dishes.Add(dish);
            await Task.CompletedTask;
        }

        public async Task UpdateAsync(Dish dish)
        {
            var oldDish = _dishes.SingleOrDefault(x => x.Id == dish.Id);
            _dishes.Remove(oldDish);
            _dishes.Add(dish);

            await Task.CompletedTask;
        }

        public async Task RemoveAsync(int id)
        {
            var dish = await GetAsync(id);
            _dishes.Remove(dish);
            await Task.CompletedTask;
        }

        
    }
}