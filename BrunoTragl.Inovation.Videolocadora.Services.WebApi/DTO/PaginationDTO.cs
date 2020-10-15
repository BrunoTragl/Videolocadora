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
        public string Skip { get; set; }
        public string Take { get; set; }

        public bool Valid()
        {
            return (!string.IsNullOrEmpty(Nome) || !string.IsNullOrEmpty(Sobrenome) || string.IsNullOrEmpty(Telefone))
                   && (!string.IsNullOrEmpty(Skip) && !string.IsNullOrEmpty(Take));
        }
    }
}
