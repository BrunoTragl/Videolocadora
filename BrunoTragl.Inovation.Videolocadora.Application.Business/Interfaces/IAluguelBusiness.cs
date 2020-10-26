using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BrunoTragl.Inovation.Videolocadora.Application.Business.Interfaces
{
    public interface IAluguelBusiness
    {
        void Add(Aluguel aluguel);
        void Edit(Aluguel actualAluguel, Aluguel editedAluguel);
        Aluguel Get(int id);
        bool Exist(int id);
        void Desactive(Aluguel aluguel);
        IEnumerable<Aluguel> Get(Expression<Func<Aluguel, bool>> exp);
        int DiasParaDevolucao();
        decimal? CalcularMulta(int id);
        bool ClientePossuiAluguelGratuito(int clienteId);
    }
}
