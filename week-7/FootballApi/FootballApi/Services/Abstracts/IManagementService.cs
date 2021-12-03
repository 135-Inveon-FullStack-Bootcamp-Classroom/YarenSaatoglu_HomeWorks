using FootballApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballApi.Services.Abstracts
{
    public interface IManagementService
    {
        public Task<IEnumerable<Management>> GetAllAsync();
        public Task<Management> GetAsync(int id);
        public Task UpdateAsync(int id, Management management);
        public Task<Management> CreateAsync(Management management);
        public Task DeleteAsync(int id);
    }
}
