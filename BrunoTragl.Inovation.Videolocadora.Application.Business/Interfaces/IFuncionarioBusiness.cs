using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BrunoTragl.Inovation.Videolocadora.Application.Business.Interfaces
{
    public interface IFuncionarioBusiness
    {
        void Add(Funcionario funcionario);
        void Edit(Funcionario funcionario);
        Funcionario Get(int id);
        IEnumerable<Funcionario> Get(Expression<Func<Funcionario, bool>> exp);
    }
}
