using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Waiter.Models;

namespace Waiter.Repositories
{
    public class InMemoryTableRepository : ITableRepository
    {

        private static ISet<Table> _tables = new HashSet<Table>()
        {
            new Table{Id=1},
            new Table{Id=2},
            new Table{Id=3},
            new Table{Id=4},
            new Table{Id=5},
        };

        public async Task<Table> GetAsync(int id)
            => await Task.FromResult(_tables.SingleOrDefault(x => x.Id == id));

        public async Task<IEnumerable<Table>> GetAllAsync()
            => await Task.FromResult(_tables);

        public async Task AddAsync(Table table)
        {
            await Task.FromResult(_tables.Add(table));
        }

        public async Task UpdateAsync(Table table)
        {
            var oldTable = _tables.SingleOrDefault(x => x.Id == table.Id);
            await Task.FromResult(_tables.Remove(oldTable));
            await Task.FromResult(_tables.Add(table));

            await Task.CompletedTask;
        }
    }
}
