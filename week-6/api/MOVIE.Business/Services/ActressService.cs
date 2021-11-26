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
    public class ActressService : IActressService
    {
        private readonly IActressRepository _actressRepository;
        public ActressService(IActressRepository actressRepository)
        {
            _actressRepository = actressRepository;
        }
        public Actress CreateActress(Actress actress)
        {
            return _actressRepository.CreateActress(actress);
        }

        public void DeleteActress(int id)
        {
            _actressRepository.DeleteActress(id);
        }

        public Actress GetActressById(int id)
        {
            return _actressRepository.GetActressById(id);
        }

        public List<Actress> GetAllActresses()
        {
            return _actressRepository.GetAllActresses();
        }

        public Actress UpdateActress(Actress actress)
        {
            return _actressRepository.UpdateActress(actress);
        }
    }
}
