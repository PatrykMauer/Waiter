using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waiter.Models;

namespace Waiter.Repositories
{
    interface IDishRepository : IRepository
    {
        Task<Dish> GetAsync(int id);
        Task<Dish> GetAsync(string name);
        Task<IEnumerable<Dish>> GetAllAsync();
        Task AddAsync(Dish dish);
        Task RemoveAsync(int id);
        Task UpdateAsync(Dish dish);
    }
}
