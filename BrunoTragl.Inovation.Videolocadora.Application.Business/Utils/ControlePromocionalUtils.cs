using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using Microsoft.Extensions.Configuration;
using System;

namespace BrunoTragl.Inovation.Videolocadora.Application.Business.Utils
{
    public static class ControlePromocionalUtils
    {
        public static ControlePromocional GetControlePromocional(IConfiguration configuration)
        {
            int periodoPromocional;
            if (int.TryParse(configuration["PeriodoPromocionalEmMeses"], out periodoPromocional))
            {
                return new ControlePromocional
                {
                    Inicio = DateTime.Now,
                    Fim = DateTime.Now.AddMonths(periodoPromocional),
                    Cadastro = DateTime.Now,
                    Ativo = true
                };
            }
            else
                return null;
        }
    }
}
