using BrunoTragl.Inovation.Videolocadora.Application.Business.Extensions;
using BrunoTragl.Inovation.Videolocadora.Application.Business.Interfaces;
using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using BrunoTragl.Inovation.Videolocadora.Infrastructure.Repository.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BrunoTragl.Inovation.Videolocadora.Application.Business
{
    public class AluguelBusiness : IAluguelBusiness
    {
        private readonly IAluguelRepository _aluguelRepository;
        private readonly IControlePromocionalBusiness _controlePromocionalBusiness;
        private readonly IConfiguration _configuration;
        public AluguelBusiness(IAluguelRepository aluguelRepository,
                               IControlePromocionalBusiness controlePromocionalBusiness,
                               IConfiguration configuration)
        {
            _aluguelRepository = aluguelRepository;
            _controlePromocionalBusiness = controlePromocionalBusiness;
            _configuration = configuration;
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
                actualAluguel.Devolveu = editedAluguel.Devolveu;
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
        public int DiasParaDevolucao()
        {
            try
            {
                return int.TryParse(_configuration["DiasAluguel"], out int diasParaDevolucao) ? diasParaDevolucao : 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public decimal? CalcularMulta(int id)
        {
            try
            {
                Aluguel aluguel = this.Get(id);
                if (aluguel == null)
                    return null;

                decimal multaDiaria = 0;
                if(decimal.TryParse(_configuration["MultaDiaria"], out multaDiaria))
                {
                    decimal diasEmAtraso = (DateTime.Now - aluguel.Devolucao).ToDecimal();
                    return diasEmAtraso > 0 ? diasEmAtraso * multaDiaria : 0;
                }

                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ClientePossuiAluguelGratuito(int clienteId)
        {
            try
            {
                ControlePromocional ultimoControlePromocional = _controlePromocionalBusiness.Last();

                IEnumerable<Aluguel> ultimosDezAlugueis = _aluguelRepository.Get(p => p.ClienteId == clienteId
                                                                              && p.Cadastro > ultimoControlePromocional.Inicio
                                                                              && p.Cadastro < ultimoControlePromocional.Fim)
                                                                            .OrderByDescending(p => p.Cadastro)
                                                                            .Take(10);

                bool atrasoMaiorQueDoisDias = _aluguelRepository.Get(p => p.ClienteId == clienteId
                                                                  && p.Cadastro > ultimoControlePromocional.Inicio
                                                                  && p.Cadastro < ultimoControlePromocional.Fim
                                                                  && (p.Devolveu > p.Devolucao.AddDays(2)
                                                                  || (p.Devolveu == null && DateTime.Now > p.Devolucao.AddDays(2))))
                                                                .Any();

                return ultimosDezAlugueis.Count() == 10 && !ultimosDezAlugueis.Any(p => (p.ValorPago == 0)) && !atrasoMaiorQueDoisDias;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
