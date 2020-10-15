using System;

namespace BrunoTragl.Inovation.Videolocadora.Domain.Model
{
    public class Aluguel
    {
        public int Id { get; set; }
        public decimal ValorPago { get; set; }
        public decimal Multa { get; set; }
        public DateTime Devolucao { get; set; }
        public Cliente Cliente { get; set; }
        public Funcionario Funcionario { get; set; }
        public Filme Filme { get; set; }
        public int ClienteId { get; set; }
        public int FuncionarioId { get; set; }
        public int FilmeId { get; set; }
        public DateTime Cadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
