using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Waiter.Models;
using Waiter.Repositories;

namespace Waiter.Services
{
    public class DishService : IDishService
    {
        private readonly IDishRepository _dishRepository;

        public DishService(IDishRepository dishRepository)
        {
            _dishRepository = dishRepository;
        }
        public async Task<IEnumerable<Dish>> GetAllAsync()
        {
            return await _dishRepository.GetAllAsync();
        }
    }
}