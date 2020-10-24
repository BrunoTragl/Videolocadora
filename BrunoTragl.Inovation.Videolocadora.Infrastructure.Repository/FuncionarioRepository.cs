using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using BrunoTragl.Inovation.Videolocadora.Infrastructure.Data.Interfaces;
using BrunoTragl.Inovation.Videolocadora.Infrastructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BrunoTragl.Inovation.Videolocadora.Infrastructure.Repository
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly IVideolocadoraContext _videolocadoraContext;
        public FuncionarioRepository(IVideolocadoraContext videolocadoraContext)
        {
            _videolocadoraContext = videolocadoraContext;
        }
        public void Add(Funcionario funcionario)
        {
            try
            {
                _videolocadoraContext.Funcionario.Add(funcionario);
                _videolocadoraContext.SaveChanges();
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
                _videolocadoraContext.Funcionario.Update(funcionario).State = EntityState.Modified;
                _videolocadoraContext.SaveChanges();
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
                return _videolocadoraContext.Funcionario.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<Funcionario> Get(Expression<Func<Funcionario, bool>> exp)
        {
            return _videolocadoraContext.Funcionario.Where(exp).OrderBy(p => p.Nome);
        }
    }
}
