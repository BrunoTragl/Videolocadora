using AutoMapper;
using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using BrunoTragl.Inovation.Videolocadora.Services.WebApi.Map;
using System;

namespace BrunoTragl.Inovation.Videolocadora.Services.WebApi.Model
{
    public class AluguelModel
    {
        private readonly IMapper _mapper; 
        public AluguelModel()
        {
            _mapper = MapConfiguration.Config();
        }

        public int Id { get; set; }
        public decimal ValorPago { get; set; }
        public decimal Multa { get; set; }
        public DateTime Devolucao { get; set; }
        public ClienteModel Cliente { get; set; }
        public FuncionarioModel Funcionario { get; set; }
        public FilmeModel Filme { get; set; }
        public int ClienteId { get; set; }
        public int FuncionarioId { get; set; }
        public int FilmeId { get; set; }
        public DateTime Cadastro { get; set; }
        public bool Ativo { get; set; }

        public static AluguelModel ToModel(Aluguel aluguel)
        {
            try
            {
                if (aluguel == null)
                    return null;

                IMapper mapper = MapConfiguration.Config();
                return mapper.Map<AluguelModel>(aluguel);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Aluguel ToDomain()
        {
            try
            {
                Aluguel domain = new Aluguel();
                _mapper.Map(this, domain);
                return domain;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool IsValid()
        {
            return Cliente != null && Filme != null && Funcionario != null;
        }

        public bool IsValidToDesactive()
        {
            return ValorPago == 0 && Multa == 0;
        }

        public BodyModel<AluguelModel> ToBody()
        {
            return new BodyModel<AluguelModel>
            {
                Data = this
            };
        }
    }
}
