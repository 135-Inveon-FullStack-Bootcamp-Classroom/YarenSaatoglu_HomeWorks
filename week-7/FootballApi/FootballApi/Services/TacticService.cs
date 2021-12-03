using FootballApi.Data;
using FootballApi.Entities;
using FootballApi.Services.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballApi.Services
{
    public class TacticService:ITacticService
    {
        private readonly ApplicationDbContext _context;
        public TacticService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Tactic> CreateAsync(Tactic tactic)
        {
            _context.Tactics.Add(tactic);
            await _context.SaveChangesAsync();
            return tactic;
        }

        public async Task DeleteAsync(int id)
        {
            var tactic = await _context.Tactics.FindAsync(id);

            if (tactic == null)
            {
                throw new Exception("Taktik Bulunamadı");
            }

            _context.Tactics.Remove(tactic);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Tactic>> GetAllAsync()
        {
            return await _context.Tactics.ToListAsync();
        }

        public async Task<Tactic> GetAsync(int id)
        {
            var tactic = await _context.Tactics.FindAsync(id);
            return tactic;
        }

        public async Task UpdateAsync(int id, Tactic tactic)
        {
            _context.Tactics.Update(tactic);
            await _context.SaveChangesAsync();
        }
    }
}
