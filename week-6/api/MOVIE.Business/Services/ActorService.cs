using MOVIE.Business.Abstracts;
using MOVIE.DataAccess.Abstracts;
using MOVIE.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVIE.Business.Services
{
    public class ActorService : IActorService
    {
        private readonly IActorRepository _actorRepository;
        public ActorService(IActorRepository actorRepository)
        {
            _actorRepository = actorRepository;
        }
        public Actor CreateActor(Actor actor)
        {
            return _actorRepository.CreateActor(actor);
        }

        public void DeleteActor(int id)
        {
            _actorRepository.DeleteActor(id);
        }

        public Actor GetActorById(int id)
        {
           return _actorRepository.GetActorById(id);
        }

        public List<Actor> GetAllActors()
        {
            return _actorRepository.GetAllActors();
        }

        public Actor UpdateActor(Actor actor)
        {
            return _actorRepository.UpdateActor(actor);
        }
    }
}
