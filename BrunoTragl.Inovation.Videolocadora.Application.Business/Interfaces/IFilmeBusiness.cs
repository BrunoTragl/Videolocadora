using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BrunoTragl.Inovation.Videolocadora.Application.Business.Interfaces
{
    public interface IFilmeBusiness
    {
        void Add(Filme filme);
        void Edit(Filme filme);
        Filme Get(int id);
        IEnumerable<Filme> Get(Expression<Func<Filme, bool>> exp);
    }
}
