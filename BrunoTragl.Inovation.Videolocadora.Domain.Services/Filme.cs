using System;

namespace BrunoTragl.Inovation.Videolocadora.Domain.Model
{
    public class Filme
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Cadastro { get; set; }
        public virtual Aluguel Aluguel { get; set; }
        public bool Ativo { get; set; }
    }
}
