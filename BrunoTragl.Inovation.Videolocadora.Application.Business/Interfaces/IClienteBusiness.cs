using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BrunoTragl.Inovation.Videolocadora.Application.Business.Interfaces
{
    public interface IClienteBusiness
    {
        void Add(Cliente cliente);
        void Edit(Cliente actualCliente, Cliente editedCliente);
        Cliente Get(int id);
        IEnumerable<Cliente> Get(Expression<Func<Cliente, bool>> exp);
        bool PossuiPendencias(Cliente cliente);
        void Desactive(Cliente cliente);
    }
}
