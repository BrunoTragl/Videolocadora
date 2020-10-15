using BrunoTragl.Inovation.Videolocadora.Application.Business.Interfaces;
using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using BrunoTragl.Inovation.Videolocadora.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BrunoTragl.Inovation.Videolocadora.Application.Business
{
    public class ClienteBusiness : IClienteBusiness
    {
        private readonly IClienteRepository _clienteRepository;
        public ClienteBusiness(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }
        public void Add(Cliente cliente)
        {
            try
            {
                _clienteRepository.Add(cliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Edit(Cliente cliente)
        {
            try
            {
                _clienteRepository.Edit(cliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Cliente Get(int id)
        {
            try
            {
                return _clienteRepository.Get(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<Cliente> Get(Expression<Func<Cliente, bool>> exp)
        {
            return _clienteRepository.Get(exp);
        }
    }
}
