using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waiter.Models;

namespace Waiter.Services
{
    public interface IDishService : IService
    {
        Task<IEnumerable<Dish>> GetAllAsync();
    }
}
