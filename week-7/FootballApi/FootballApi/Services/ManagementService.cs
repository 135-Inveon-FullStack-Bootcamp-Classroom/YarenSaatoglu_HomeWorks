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
    public class ManagementService : IManagementService
    {
        private readonly ApplicationDbContext _context;
        public ManagementService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Management> CreateAsync(Management management)
        {
             _context.Managements.Add(management);
            await _context.SaveChangesAsync();
            return management;
        }

        public async Task DeleteAsync(int id)
        {
            var management = await _context.Managements.FindAsync(id);

            if (management == null)
            {
                throw new Exception("Yönetici Bulunamadı");
            }

            _context.Managements.Remove(management);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Management>> GetAllAsync()
        {
            return await _context.Managements.ToListAsync();
        }

        public async Task<Management> GetAsync(int id)
        {
            var management = await _context.Managements.FindAsync(id);
            return management;
        }

        public async Task UpdateAsync(int id, Management management)
        {
            _context.Managements.Update(management);
            await _context.SaveChangesAsync();
        }
    }
}
