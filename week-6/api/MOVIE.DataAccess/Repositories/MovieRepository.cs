using MOVIE.DataAccess.Abstracts;
using MOVIE.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVIE.DataAccess.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieDbContext _dbContext;
        public MovieRepository( MovieDbContext dbContext)
        {
            _dbContext = dbContext;     
        }
        public Movie CreateMovie(Movie movie)
        {
            _dbContext.Movies.Add(movie);
            _dbContext.SaveChanges();
            return movie;
        }

        public void DeleteMovie(int id)
        {
            var deletedItem = GetMovieById(id);
            _dbContext.Movies.Remove(deletedItem);
            _dbContext.SaveChanges();
        }

        public List<Movie> GetAllMovies()
        {
            return _dbContext.Movies.ToList();
        }

        public Movie GetMovieById(int id)
        {
            return _dbContext.Movies.Find(id);
        }

        public Movie UpdateMovie(Movie movie)
        {
            _dbContext.Movies.Update(movie);
            _dbContext.SaveChanges();
            return movie;
        }
    }
}
