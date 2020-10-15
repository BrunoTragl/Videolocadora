using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BrunoTragl.Inovation.Videolocadora.Infrastructure.Repository.Interfaces
{
    public interface IAluguelRepository
    {
        Aluguel Get(int id);
        IEnumerable<Aluguel> Get(Expression<Func<Aluguel, bool>> exp);
        bool Any(int id);
        void Add(Aluguel aluguel);
        void Edit(Aluguel aluguel);
    }
}
