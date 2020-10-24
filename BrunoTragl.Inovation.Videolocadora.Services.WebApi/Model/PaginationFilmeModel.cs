using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using System;
using System.Linq.Expressions;

namespace BrunoTragl.Inovation.Videolocadora.Services.WebApi.Model
{
    public class PaginationFilmeModel
    {
        public string Titulo { get; set; }
        public int Skip { get; set; }
        public int Take { get; set; }

        public bool IsValid()
        {
            return !string.IsNullOrEmpty(Titulo) && Take > 0;
        }

        public Expression<Func<Filme, bool>> Search()
        {
            return p => p.Titulo.Contains(Titulo);
        }
    }
}
