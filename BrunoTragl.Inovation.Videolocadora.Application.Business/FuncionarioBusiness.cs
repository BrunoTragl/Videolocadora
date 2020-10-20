using BrunoTragl.Inovation.Videolocadora.Application.Business.Interfaces;
using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using BrunoTragl.Inovation.Videolocadora.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BrunoTragl.Inovation.Videolocadora.Application.Business
{
    public class FuncionarioBusiness : IFuncionarioBusiness
    {
        private readonly IFuncionarioRepository _funcionarioRepository;
        private readonly IAluguelRepository _aluguelRepository;
        public FuncionarioBusiness(IAluguelRepository aluguelRepository, IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
            _aluguelRepository = aluguelRepository;
        }
        public void Add(Funcionario funcionario)
        {
            try
            {
                _funcionarioRepository.Add(funcionario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Desactive(Funcionario funcionario)
        {
            try
            {
                funcionario.Ativo = false;
                _funcionarioRepository.Edit(funcionario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Edit(Funcionario actualFuncionario, Funcionario editedFuncionario)
        {
            try
            {
                actualFuncionario.Email = editedFuncionario.Email;
                actualFuncionario.Nome = editedFuncionario.Nome;
                actualFuncionario.Sobrenome = editedFuncionario.Sobrenome;
                _funcionarioRepository.Edit(actualFuncionario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Funcionario Get(int id)
        {
            try
            {
                return _funcionarioRepository.Get(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Funcionario Get(string login, string senha)
        {
            try
            {
                return _funcionarioRepository.Get(f => f.Login == login && f.Senha == senha).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<Funcionario> Get(Expression<Func<Funcionario, bool>> exp)
        {
            return _funcionarioRepository.Get(exp);
        }
        public bool JaRealizouAluguel(Funcionario funcionario)
        {
            try
            {
                return _aluguelRepository.Get(a => a.Funcionario.Id == funcionario.Id).Any();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void TrocarSenha(Funcionario funcionario, string novaSenha)
        {
            try
            {
                funcionario.Senha = novaSenha;
                _funcionarioRepository.Edit(funcionario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
