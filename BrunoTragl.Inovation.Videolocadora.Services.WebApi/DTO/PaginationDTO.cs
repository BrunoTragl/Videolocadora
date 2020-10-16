using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using System;
using System.Linq.Expressions;

namespace BrunoTragl.Inovation.Videolocadora.Services.WebApi.DTO
{
    public class PaginationDTO
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public int Skip { get; set; }
        public int Take { get; set; }

        public bool IsValid()
        {
            return (!string.IsNullOrEmpty(Nome) || !string.IsNullOrEmpty(Sobrenome) || string.IsNullOrEmpty(Telefone)) && Take > 0;
        }

        public Expression<Func<Cliente, bool>> Search()
        {
            return p => p.Nome.Contains(!string.IsNullOrEmpty(Nome) ? Nome : "")
                     && p.Sobrenome.Contains(!string.IsNullOrEmpty(Sobrenome) ? Sobrenome : "")
                     && p.Telefone.Contains(!string.IsNullOrEmpty(Telefone) ? Telefone : "")
                     && p.Email.Contains(!string.IsNullOrEmpty(Email) ? Email : "");
        }
    }
}
