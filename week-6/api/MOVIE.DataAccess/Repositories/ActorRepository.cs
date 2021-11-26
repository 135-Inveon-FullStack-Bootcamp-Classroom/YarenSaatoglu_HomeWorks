using MOVIE.DataAccess.Abstracts;
using MOVIE.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVIE.DataAccess.Repositories
{
    public class ActorRepository : IActorRepository
    {
        private readonly MovieDbContext _dbContext;
        public ActorRepository(MovieDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Actor CreateActor(Actor actor)
        {
            _dbContext.Actors.Add(actor);
            _dbContext.SaveChanges();
            return actor;
        }

        public void DeleteActor(int id)
        {
            var deletedItem = GetActorById(id);
            _dbContext.Actors.Remove(deletedItem);
            _dbContext.SaveChanges();
        }

        public Actor GetActorById(int id)
        {
            return _dbContext.Actors.Find(id);
        }

        public List<Actor> GetAllActors()
        {
            return _dbContext.Actors.ToList();
        }

        public Actor UpdateActor(Actor actor)
        {
            _dbContext.Actors.Update(actor);
            _dbContext.SaveChanges();
            return actor;
        }
    }
}
