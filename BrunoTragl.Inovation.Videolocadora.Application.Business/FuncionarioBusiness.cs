using BrunoTragl.Inovation.Videolocadora.Application.Business.Interfaces;
using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using BrunoTragl.Inovation.Videolocadora.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BrunoTragl.Inovation.Videolocadora.Application.Business
{
    public class FuncionarioBusiness : IFuncionarioBusiness
    {
        private readonly IFuncionarioRepository _funcionarioRepository;
        public FuncionarioBusiness(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
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
        public void Edit(Funcionario funcionario)
        {
            try
            {
                _funcionarioRepository.Edit(funcionario);
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
        public IEnumerable<Funcionario> Get(Expression<Func<Funcionario, bool>> exp)
        {
            return _funcionarioRepository.Get(exp);
        }
    }
}
