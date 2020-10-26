using System;
using System.Collections.Generic;

namespace BrunoTragl.Inovation.Videolocadora.Domain.Model
{
    public class Aluguel
    {
        public int Id { get; set; }
        public decimal ValorPago { get; set; }
        public decimal? Multa { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Funcionario Funcionario { get; set; }
        public virtual Filme Filme { get; set; }
        public virtual int ClienteId { get; set; }
        public virtual int FuncionarioId { get; set; }
        public virtual int FilmeId { get; set; }
        public DateTime Devolucao { get; set; }
        public DateTime? Devolveu { get; set; }
        public DateTime Cadastro { get; set; }
        public bool Ativo { get; set; }
    }
}
