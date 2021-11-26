using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOVIE.Business.Abstracts;
using MOVIE.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOVIE.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorController : ControllerBase
    {
        private readonly IActorService _actorService;
        public ActorController(IActorService actorService)
        {
            _actorService = actorService;
        }
        [HttpGet]
        public List<Actor> Get()
        {
            return _actorService.GetAllActors();
        }
        [HttpGet("{id}")]
        public Actor Get(int id)
        {
            return _actorService.GetActorById(id);
        }
        [HttpPost]
        public Actor Post([FromBody] Actor actor)
        {
            return _actorService.CreateActor(actor);
        }

        [HttpPut]
        public Actor Put([FromBody] Actor actor)
        {
            return _actorService.UpdateActor(actor);
        }

        [HttpDelete("{id}")]
        public void Delete([FromBody] int id)
        {
            _actorService.DeleteActor(id);
        }
    }
}
