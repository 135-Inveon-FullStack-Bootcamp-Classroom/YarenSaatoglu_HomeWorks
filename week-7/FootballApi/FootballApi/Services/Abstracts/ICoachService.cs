using FootballApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballApi.Services.Abstracts
{
    public interface ICoachService
    {
        public Task<IEnumerable<Coach>> GetAllAsync();
        public Task<Coach> GetAsync(int id);
        public Task UpdateAsync(int id, Coach coach);
        public Task<Coach> CreateAsync(Coach coach);
        public Task DeleteAsync(int id);
    }
}
