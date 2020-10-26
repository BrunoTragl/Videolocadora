using BrunoTragl.Inovation.Videolocadora.Application.Business.Interfaces;
using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using BrunoTragl.Inovation.Videolocadora.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace BrunoTragl.Inovation.Videolocadora.Application.Business
{
    public class FilmeBusiness : IFilmeBusiness
    {
        private readonly IFilmeRepository _filmeRepository;
        private readonly IAluguelRepository _aluguelRepository;
        public FilmeBusiness(IAluguelRepository aluguelRepository, IFilmeRepository filmeRepository)
        {
            _filmeRepository = filmeRepository;
            _aluguelRepository = aluguelRepository;
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
        public void Desactive(Filme filme)
        {
            try
            {
                filme.Ativo = false;
                _filmeRepository.Edit(filme);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Edit(Filme actualFilme, Filme editedFilme)
        {
            try
            {
                actualFilme.Descricao = editedFilme.Descricao;
                actualFilme.Titulo = editedFilme.Titulo;
                actualFilme.Valor = editedFilme.Valor;
                actualFilme.UrlImagem = editedFilme.UrlImagem;
                _filmeRepository.Edit(actualFilme);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool FilmeJaAlugado(Filme filme)
        {
            try
            {
                return true; // _aluguelRepository.Get(a => a.Filme.Id == filme.Id).Count() > 0;
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
        public IEnumerable<Filme> Pagination(Expression<Func<Filme, bool>> exp, int skip, int take)
        {
            try
            {
                return _filmeRepository.Pagination(exp, skip, take);
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
                return _filmeRepository.PaginationUnselectedFilmes(exp, skip, take, filmesSelecionados);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
