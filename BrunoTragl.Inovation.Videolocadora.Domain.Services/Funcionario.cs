using System;

namespace BrunoTragl.Inovation.Videolocadora.Domain.Model
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public DateTime Cadastro { get; set; }
        public virtual Aluguel Aluguel { get; set; }
        public bool Ativo { get; set; }
    }
}
