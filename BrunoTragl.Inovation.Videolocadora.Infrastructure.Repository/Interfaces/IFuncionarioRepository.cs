using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BrunoTragl.Inovation.Videolocadora.Infrastructure.Repository.Interfaces
{
    public interface IFuncionarioRepository
    {
        Funcionario Get(int id);
        IEnumerable<Funcionario> Get(Expression<Func<Funcionario, bool>> exp);
        void Add(Funcionario filme);
        void Edit(Funcionario filme);
    }
}
