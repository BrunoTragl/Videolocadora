using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using System;
using System.Linq.Expressions;

namespace BrunoTragl.Inovation.Videolocadora.Services.WebApi.Model
{
    public class PaginationClienteModel
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int Skip { get; set; }
        public int Take { get; set; }

        public bool IsValid()
        {
            return (!string.IsNullOrEmpty(Nome) || !string.IsNullOrEmpty(Sobrenome)) && Take > 0;
        }

        public Expression<Func<Cliente, bool>> Search()
        {
            return p => p.Nome.Contains(!string.IsNullOrEmpty(Nome) ? Nome : "")
                     && p.Sobrenome.Contains(!string.IsNullOrEmpty(Sobrenome) ? Sobrenome : "");
        }
    }
}
