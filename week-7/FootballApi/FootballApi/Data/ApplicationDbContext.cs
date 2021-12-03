using FootballApi.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Coach> Coaches { get; set; }
        public DbSet<Footballer> Footballers { get; set; }
        public DbSet<Management> Managements { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Tactic> Tactics { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
