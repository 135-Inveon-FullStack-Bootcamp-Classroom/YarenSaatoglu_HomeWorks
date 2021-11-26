﻿using MOVIE.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVIE.Business.Abstracts
{
    public interface IActressService
    {
        List<Actress> GetAllActresses();
        Actress GetActressById(int id);
        Actress CreateActress(Actress actress);
        Actress UpdateActress(Actress actress);
        void DeleteActress(int id);
    }
}
