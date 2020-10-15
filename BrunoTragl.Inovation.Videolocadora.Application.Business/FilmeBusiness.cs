using BrunoTragl.Inovation.Videolocadora.Application.Business.Interfaces;
using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using BrunoTragl.Inovation.Videolocadora.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BrunoTragl.Inovation.Videolocadora.Application.Business
{
    public class FilmeBusiness : IFilmeBusiness
    {
        private readonly IFilmeRepository _filmeRepository;
        public FilmeBusiness(IFilmeRepository filmeRepository)
        {
            _filmeRepository = filmeRepository;
        }
        public void Add(Filme filme)
        {
            try
            {
                _filmeRepository.Add(filme);
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
                _filmeRepository.Edit(filme);
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
                return _filmeRepository.Get(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public IEnumerable<Filme> Get(Expression<Func<Filme, bool>> exp)
        {
            return _filmeRepository.Get(exp);
        }
    }
}
