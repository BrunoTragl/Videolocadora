using BrunoTragl.Inovation.Videolocadora.Application.Business.Interfaces;
using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using BrunoTragl.Inovation.Videolocadora.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BrunoTragl.Inovation.Videolocadora.Application.Business
{
    public class AluguelBusiness : IAluguelBusiness
    {
        private readonly IAluguelRepository _aluguelRepository;
        public AluguelBusiness(IAluguelRepository aluguelRepository)
        {
            _aluguelRepository = aluguelRepository;
        }
        public Aluguel Get(int id)
        {
            try
            {
                return _aluguelRepository.Get(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<Aluguel> Get(Expression<Func<Aluguel, bool>> exp)
        {
            try
            {
                return _aluguelRepository.Get(exp);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Add(Aluguel aluguel)
        {
            try
            {
                _aluguelRepository.Add(aluguel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Edit(Aluguel actualAluguel, Aluguel editedAluguel)
        {
            try
            {
                actualAluguel.Devolucao = editedAluguel.Devolucao;
                actualAluguel.Multa = editedAluguel.Multa;
                actualAluguel.ValorPago = editedAluguel.ValorPago;
                _aluguelRepository.Edit(actualAluguel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Desactive(Aluguel aluguel)
        {
            try
            {
                aluguel.Ativo = false;
                _aluguelRepository.Edit(aluguel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Exist(int id)
        {
            try
            {
                return _aluguelRepository.Any(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
