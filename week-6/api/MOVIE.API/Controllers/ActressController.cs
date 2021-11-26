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
    public class ActressController : ControllerBase
    {
        private readonly IActressService _actressService;
        public ActressController(IActressService actressService)
        {
            _actressService = actressService;
        }
        [HttpGet]
        public List<Actress> Get()
        {
            return _actressService.GetAllActresses();
        }
        [HttpGet("{id}")]
        public Actress Get(int id)
        {
            return _actressService.GetActressById(id);
        }
        [HttpPost]
        public Actress Post([FromBody] Actress actor)
        {
            return _actressService.CreateActress(actor);
        }

        [HttpPut]
        public Actress Put([FromBody] Actress actor)
        {
            return _actressService.UpdateActress(actor);
        }

        [HttpDelete("{id}")]
        public void Delete([FromBody] int id)
        {
            _actressService.DeleteActress(id);
        }
    }
}
