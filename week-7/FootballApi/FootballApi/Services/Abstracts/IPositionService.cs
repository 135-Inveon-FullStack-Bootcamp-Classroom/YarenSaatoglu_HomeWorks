using FootballApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballApi.Services.Abstracts
{
    public interface IPositionService
    {
        public Task<IEnumerable<Position>> GetAllAsync();
        public Task<Position> GetAsync(int id);
        public Task UpdateAsync(int id, Position position);
        public Task<Position> CreateAsync(Position position);
        public Task DeleteAsync(int id);
    }
}
