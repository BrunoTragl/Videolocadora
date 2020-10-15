using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BrunoTragl.Inovation.Videolocadora.Infrastructure.Repository.Interfaces
{
    public interface IFilmeRepository
    {
        Filme Get(int id);
        IEnumerable<Filme> Get(Expression<Func<Filme, bool>> exp);
        void Add(Filme filme);
        void Edit(Filme filme);
    }
}
