﻿using FootballApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballApi.Services.Abstracts
{
    public interface ITacticService
    {
        public Task<IEnumerable<Tactic>> GetAllAsync();
        public Task<Tactic> GetAsync(int id);
        public Task UpdateAsync(int id, Tactic tactic);
        public Task<Tactic> CreateAsync(Tactic tactic);
        public Task DeleteAsync(int id);
    }
}
