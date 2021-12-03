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
    public class CoachService:ICoachService
    {
        private readonly ApplicationDbContext _context;
        public CoachService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Coach> CreateAsync(Coach coach)
        {
            _context.Coaches.Add(coach);
            await _context.SaveChangesAsync();
            return coach;
        }

        public async Task DeleteAsync(int id)
        {
            var coach = await _context.Coaches.FindAsync(id);

            if (coach == null)
            {
                throw new Exception("Koç Bulunamadı");
            }

            _context.Coaches.Remove(coach);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Coach>> GetAllAsync()
        {
            return await _context.Coaches.ToListAsync();
        }

        public async Task<Coach> GetAsync(int id)
        {
            var coach = await _context.Coaches.FindAsync(id);
            return coach;
        }

        public async Task UpdateAsync(int id, Coach coach)
        {
            _context.Coaches.Update(coach);
            await _context.SaveChangesAsync();
        }
    }
}
