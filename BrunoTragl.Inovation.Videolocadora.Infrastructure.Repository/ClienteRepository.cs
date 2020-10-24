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
    public class ClienteRepository : IClienteRepository
    {
        private readonly IVideolocadoraContext _videolocadoraContext;
        public ClienteRepository(IVideolocadoraContext videolocadoraContext)
        {
            _videolocadoraContext = videolocadoraContext;
        }
        public void Add(Cliente cliente)
        {
            try
            {
                _videolocadoraContext.Cliente.Add(cliente);
                _videolocadoraContext.SaveChanges();
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
                _videolocadoraContext.Cliente.Attach(cliente);
                _videolocadoraContext.Cliente.Update(cliente).State = EntityState.Modified;
                _videolocadoraContext.SaveChanges();
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
                return _videolocadoraContext.Cliente.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<Cliente> Get(Expression<Func<Cliente, bool>> exp)
        {
            return _videolocadoraContext.Cliente.Where(exp).OrderBy(p => p.Nome);
        }
        public IEnumerable<Cliente> Pagination(Expression<Func<Cliente, bool>> exp, int skip, int take)
        {
            try
            {
                return _videolocadoraContext.Cliente.Where(exp).OrderBy(p => p.Nome).Skip(skip).Take(take);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
