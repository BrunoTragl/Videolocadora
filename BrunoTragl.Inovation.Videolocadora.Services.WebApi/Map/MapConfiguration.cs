using AutoMapper;
using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using BrunoTragl.Inovation.Videolocadora.Services.WebApi.Model;
using System;

namespace BrunoTragl.Inovation.Videolocadora.Services.WebApi.Map
{
    public static class MapConfiguration
    {
        public static IMapper Config()
        {
            try
            {
                return new MapperConfiguration(c =>
                {
                    c.CreateMap<Aluguel, AluguelModel>();
                    c.CreateMap<AluguelModel, Aluguel>();
                    c.CreateMap<Cliente, ClienteModel>();
                    c.CreateMap<ClienteModel, Cliente>();
                    c.CreateMap<Filme, FilmeModel>();
                    c.CreateMap<FilmeModel, Filme>();
                    c.CreateMap<Funcionario, FuncionarioModel>();
                    c.CreateMap<FuncionarioModel, Funcionario>();
                }).CreateMapper();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
