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
    public class AluguelRepository : IAluguelRepository
    {
        private readonly IVideolocadoraContext _videolocadoraContext;
        public AluguelRepository(IVideolocadoraContext videolocadoraContext)
        {
            _videolocadoraContext = videolocadoraContext;
        }
        public void Add(Aluguel aluguel)
        {
            try
            {
                _videolocadoraContext.Cliente.Attach(aluguel.Cliente);
                _videolocadoraContext.Funcionario.Attach(aluguel.Funcionario);
                _videolocadoraContext.Filme.Attach(aluguel.Filme);
                _videolocadoraContext.Aluguel.Add(aluguel);
                _videolocadoraContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Any(int id)
        {
            try
            {
                return _videolocadoraContext.Aluguel.Any(a => a.Id == id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Edit(Aluguel aluguel)
        {
            try
            {
                _videolocadoraContext.Cliente.Attach(aluguel.Cliente);
                _videolocadoraContext.Funcionario.Attach(aluguel.Funcionario);
                _videolocadoraContext.Filme.Attach(aluguel.Filme);
                _videolocadoraContext.Aluguel.Attach(aluguel);
                _videolocadoraContext.Aluguel.Update(aluguel).State = EntityState.Modified;
                _videolocadoraContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Aluguel Get(int id)
        {
            try
            {
                return _videolocadoraContext.Aluguel.Find(id);
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
                return _videolocadoraContext.Aluguel.Include(i => i.Cliente).Include(i => i.Filme).Include(i => i.Funcionario).Where(exp).OrderBy(p => p.Cadastro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
