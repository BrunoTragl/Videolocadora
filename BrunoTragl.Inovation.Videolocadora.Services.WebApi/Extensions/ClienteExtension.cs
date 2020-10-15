using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using System;

namespace BrunoTragl.Inovation.Videolocadora.Services.WebApi.Extensions
{
    public static class ClienteExtension
    {
        public static bool IsValid(this Cliente cliente)
        {
            cliente.Ativo = true;
            cliente.Cadastro = DateTime.Now;
            return !string.IsNullOrEmpty(cliente.Nome) && !string.IsNullOrEmpty(cliente.Sobrenome);
        }
    }
}
