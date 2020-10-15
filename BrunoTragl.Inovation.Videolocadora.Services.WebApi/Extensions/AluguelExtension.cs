using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using System;

namespace BrunoTragl.Inovation.Videolocadora.Services.WebApi.Extensions
{
    public static class AluguelExtension
    {
        public static bool IsValid(this Aluguel aluguel)
        {
            aluguel.Ativo = true;
            aluguel.Cadastro = DateTime.Now;
            return aluguel.Cliente != null && aluguel.Filme != null && aluguel.Funcionario != null;
        }

        public static bool IsValidToDesactive(this Aluguel aluguel)
        {
            return aluguel.ValorPago == 0 && aluguel.Multa == 0;
        }
    }
}
