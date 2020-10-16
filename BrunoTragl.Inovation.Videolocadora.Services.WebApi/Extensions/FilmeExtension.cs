using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using System;

namespace BrunoTragl.Inovation.Videolocadora.Services.WebApi.Extensions
{
    public static class FilmeExtension
    {
        public static bool IsValid(this Filme filme)
        {
            filme.Ativo = true;
            filme.Cadastro = DateTime.Now;
            return !string.IsNullOrEmpty(filme.Titulo) && !string.IsNullOrEmpty(filme.Descricao) && filme.Valor > 0;
        }
    }
}
