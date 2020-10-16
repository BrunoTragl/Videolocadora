using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using System;

namespace BrunoTragl.Inovation.Videolocadora.Services.WebApi.Extensions
{
    public static class FuncionarioExtension
    {
        public static bool IsValid(this Funcionario funcionario)
        {
            funcionario.Ativo = true;
            funcionario.Cadastro = DateTime.Now;
            return !string.IsNullOrEmpty(funcionario.Nome)
                && !string.IsNullOrEmpty(funcionario.Sobrenome)
                && !string.IsNullOrEmpty(funcionario.Login)
                && !string.IsNullOrEmpty(funcionario.Senha)
                && funcionario.ValidPassword();
        }

        public static bool ValidPassword(this Funcionario funcionario)
        {
            return funcionario?.Senha.Length >= 6;
        }

        public static bool SenhasIguais(this Funcionario funcionario, string novaSenha)
        {
            return funcionario?.Senha == novaSenha;
        }
    }
}
