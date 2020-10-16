using AutoMapper;
using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using BrunoTragl.Inovation.Videolocadora.Services.WebApi.Map;
using System;

namespace BrunoTragl.Inovation.Videolocadora.Services.WebApi.Model
{
    public class FuncionarioModel
    {
        private readonly IMapper _mapper;
        public FuncionarioModel(IMapper mapper)
        {
            _mapper = mapper;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public DateTime Cadastro { get; set; }
        public AluguelModel Aluguel { get; set; }
        public bool Ativo { get; set; }

        public static FuncionarioModel ToModel(Funcionario funcionario)
        {
            try
            {
                if (funcionario == null)
                    return null;

                IMapper mapper = MapConfiguration.Config();
                return mapper.Map<FuncionarioModel>(funcionario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Funcionario ToDomain()
        {
            try
            {
                Funcionario domain = new Funcionario();
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
            return !string.IsNullOrEmpty(Nome)
                && !string.IsNullOrEmpty(Sobrenome)
                && !string.IsNullOrEmpty(Login)
                && !string.IsNullOrEmpty(Senha)
                && ValidPassword();
        }

        public bool ValidPassword()
        {
            return Senha.Length >= 6;
        }

        public bool SenhasIguais(string novaSenha)
        {
            return Senha == novaSenha;
        }

        public BodyModel<FuncionarioModel> ToBody()
        {
            return new BodyModel<FuncionarioModel>
            {
                Data = this
            };
        }
    }
}
