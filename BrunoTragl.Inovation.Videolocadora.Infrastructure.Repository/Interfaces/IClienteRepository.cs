using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BrunoTragl.Inovation.Videolocadora.Infrastructure.Repository.Interfaces
{
    public interface IClienteRepository
    {
        Cliente Get(int id);
        IEnumerable<Cliente> Get(Expression<Func<Cliente, bool>> exp);
        void Add(Cliente cliente);
        void Edit(Cliente cliente);
        IEnumerable<Cliente> Pagination(Expression<Func<Cliente, bool>> exp, int skip, int take);
    }
}
