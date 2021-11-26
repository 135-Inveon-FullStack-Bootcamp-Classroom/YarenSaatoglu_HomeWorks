using MOVIE.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVIE.DataAccess.Abstracts
{
    public interface IMovieRepository
    {
        List<Movie> GetAllMovies();
        Movie GetMovieById(int id);
        Movie CreateMovie(Movie movie);
        Movie UpdateMovie(Movie movie);
        void DeleteMovie(int id);
    }
}
