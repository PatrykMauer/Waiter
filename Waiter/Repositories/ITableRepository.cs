﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Waiter.Models;

namespace Waiter.Repositories
{
    interface ITableRepository : IRepository
    {
        Task<Table> GetAsync(int id);
        Task<IEnumerable<Table>> GetAllAsync();
        Task AddAsync(Table table);
        Task UpdateAsync(Table table);
        Task RemoveAsync(int id);
    }
}