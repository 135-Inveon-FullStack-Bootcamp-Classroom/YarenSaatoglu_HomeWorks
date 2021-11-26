using MOVIE.DataAccess.Abstracts;
using MOVIE.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVIE.DataAccess.Repositories
{
    public class ActressRepository : IActressRepository
    {
        private readonly MovieDbContext _dbContext;
        public ActressRepository(MovieDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Actress CreateActress(Actress actress)
        {
            _dbContext.Actresses.Add(actress);
            _dbContext.SaveChanges();
            return actress;
        }

        public void DeleteActress(int id)
        {
            var deletedItem = GetActressById(id);
            _dbContext.Actresses.Remove(deletedItem);
            _dbContext.SaveChanges();
        }

        public Actress GetActressById(int id)
        {
            return _dbContext.Actresses.Find(id);
        }

        public List<Actress> GetAllActresses()
        {
            return _dbContext.Actresses.ToList();
        }

        public Actress UpdateActress(Actress actress)
        {
            _dbContext.Actresses.Update(actress);
            _dbContext.SaveChanges();
            return actress;
        }
    }
}
