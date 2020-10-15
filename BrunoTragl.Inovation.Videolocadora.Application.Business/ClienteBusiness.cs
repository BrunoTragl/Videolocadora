using BrunoTragl.Inovation.Videolocadora.Application.Business.Interfaces;
using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using BrunoTragl.Inovation.Videolocadora.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BrunoTragl.Inovation.Videolocadora.Application.Business
{
    public class ClienteBusiness : IClienteBusiness
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IAluguelRepository _aluguelRepository;
        public ClienteBusiness(IAluguelRepository aluguelRepository, IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
            _aluguelRepository = aluguelRepository;
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
        public void Desactive(Cliente cliente)
        {
            try
            {
                cliente.Ativo = false;
                _clienteRepository.Edit(cliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Edit(Cliente actualCliente, Cliente editedCliente)
        {
            try
            {
                actualCliente.Email = editedCliente.Email;
                actualCliente.Nascimento = editedCliente.Nascimento;
                actualCliente.Telefone = editedCliente.Telefone;
                _clienteRepository.Edit(actualCliente);
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
        public bool PossuiPendencias(Cliente cliente)
        {
            try
            {
                IEnumerable<Aluguel> alugueis = _aluguelRepository.Get(a => a.Cliente.Id == cliente.Id);
                return alugueis.Any(a => a.Ativo && (a.ValorPago <= 0 || a.Devolucao == null));
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
