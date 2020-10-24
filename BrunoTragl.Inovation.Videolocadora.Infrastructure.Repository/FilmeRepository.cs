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
    public class FilmeRepository : IFilmeRepository
    {
        private readonly IVideolocadoraContext _videolocadoraContext;
        public FilmeRepository(IVideolocadoraContext videolocadoraContext)
        {
            _videolocadoraContext = videolocadoraContext;
        }
        public void Add(Filme filme)
        {
            try
            {
                _videolocadoraContext.Filme.Add(filme);
                _videolocadoraContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Edit(Filme filme)
        {
            try
            {
                _videolocadoraContext.Filme.Attach(filme);
                _videolocadoraContext.Filme.Update(filme).State = EntityState.Modified;
                _videolocadoraContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Filme Get(int id)
        {
            try
            {
                return _videolocadoraContext.Filme.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<Filme> Get(Expression<Func<Filme, bool>> exp)
        {
            return _videolocadoraContext.Filme.Where(exp).OrderBy(p => p.Titulo);
        }
        public IEnumerable<Filme> Pagination(Expression<Func<Filme, bool>> exp, int skip, int take)
        {
            try
            {
                return _videolocadoraContext.Filme.Where(exp).OrderBy(p => p.Titulo).Skip(skip).Take(take);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Filme> PaginationUnselectedFilmes(Expression<Func<Filme, bool>> exp, int skip, int take, IEnumerable<Filme> filmesSelecionados)
        {
            try
            {
                IEnumerable<Filme> filmes = _videolocadoraContext.Filme.Where(exp).OrderBy(p => p.Titulo);
                filmes = filmes.Where(f => !filmesSelecionados.Any(fs => fs.Id == f.Id));
                return filmes.Skip(skip).Take(take);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
