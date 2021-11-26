using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MOVIE.Business.Abstracts;
using MOVIE.Business.Services;
using MOVIE.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOVIE.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }
        [HttpGet]
        public List<Movie> Get()
        {
           return _movieService.GetAllMovies();
        }
        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return _movieService.GetMovieById(id);
        }
        [HttpPost]
        public Movie Post([FromBody] Movie movie)
        {
            return _movieService.CreateMovie(movie);
        }

        [HttpPut]
        public Movie Put([FromBody] Movie movie)
        {
            return _movieService.UpdateMovie(movie);
        }

        [HttpDelete("{id}")]
        public void Delete([FromBody] int id)
        {
            _movieService.DeleteMovie(id);
        }
    }
}
