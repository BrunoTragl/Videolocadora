using AutoMapper;
using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using BrunoTragl.Inovation.Videolocadora.Services.WebApi.Map;
using System;
using System.Collections.Generic;

namespace BrunoTragl.Inovation.Videolocadora.Services.WebApi.Model
{
    public class ClienteModel
    {
        private readonly IMapper _mapper;
        public ClienteModel(IMapper mapper)
        {
            _mapper = mapper;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public DateTime Nascimento { get; set; }
        public DateTime Cadastro { get; set; }
        public AluguelModel Aluguel { get; set; }
        public bool Ativo { get; set; }

        public static ClienteModel ToModel(Cliente cliente)
        {
            try
            {
                if (cliente == null)
                    return null;

                IMapper mapper = MapConfiguration.Config();
                return mapper.Map<ClienteModel>(cliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static IEnumerable<ClienteModel> ToListModel(IEnumerable<Cliente> listCliente)
        {
            try
            {
                if (listCliente == null)
                    return null;

                IMapper mapper = MapConfiguration.Config();
                return mapper.Map<IEnumerable<ClienteModel>>(listCliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Cliente ToDomain()
        {
            try
            {
                Cliente domain = new Cliente();
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
            return !string.IsNullOrEmpty(Nome) && !string.IsNullOrEmpty(Sobrenome);
        }

        public BodyModel<ClienteModel> ToBody()
        {
            return new BodyModel<ClienteModel>
            {
                Data = this
            };
        }
    }
}
