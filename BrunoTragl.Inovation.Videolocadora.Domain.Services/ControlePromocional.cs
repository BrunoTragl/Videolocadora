using System;

namespace BrunoTragl.Inovation.Videolocadora.Domain.Model
{
    public class ControlePromocional
    {
        public int Id { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public DateTime Cadastro { get; set; }
        public bool Ativo { get; set; }
    }   
}
