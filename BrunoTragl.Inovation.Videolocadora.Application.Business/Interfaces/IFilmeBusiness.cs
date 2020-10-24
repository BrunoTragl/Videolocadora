using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BrunoTragl.Inovation.Videolocadora.Application.Business.Interfaces
{
    public interface IFilmeBusiness
    {
        void Add(Filme filme);
        void Edit(Filme actualFilme, Filme editedFilme);
        Filme Get(int id);
        IEnumerable<Filme> Get(Expression<Func<Filme, bool>> exp);
        IEnumerable<Filme> Pagination(Expression<Func<Filme, bool>> exp, int skip, int take);
        IEnumerable<Filme> PaginationUnselectedFilmes(Expression<Func<Filme, bool>> exp, int skip, int take, IEnumerable<Filme> filmesSelecionados);
        bool FilmeJaAlugado(Filme filme);
        void Desactive(Filme filme);
    }
}
