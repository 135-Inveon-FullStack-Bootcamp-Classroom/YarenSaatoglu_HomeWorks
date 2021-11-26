using MOVIE.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVIE.Business.Abstracts
{
    public interface IActorService
    {
        List<Actor> GetAllActors();
        Actor GetActorById(int id);
        Actor CreateActor(Actor actor);
        Actor UpdateActor(Actor actor);
        void DeleteActor(int id);
    }
}
