using BrunoTragl.Inovation.Videolocadora.Application.Business;
using BrunoTragl.Inovation.Videolocadora.Application.Business.Interfaces;
using BrunoTragl.Inovation.Videolocadora.Infrastructure.Data;
using BrunoTragl.Inovation.Videolocadora.Infrastructure.Data.Interfaces;
using BrunoTragl.Inovation.Videolocadora.Infrastructure.Repository;
using BrunoTragl.Inovation.Videolocadora.Infrastructure.Repository.Interfaces;
using BrunoTragl.Inovation.Videolocadora.Services.WebApi.Map;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BrunoTragl.Inovation.Videolocadora.Services.WebApi.IOC
{
    public static class DependencyInjection
    {
        public static void Container(IServiceCollection services)
        {
            try
            {
                services.AddScoped<IVideolocadoraContext, VideolocadoraContext>();
                services.AddTransient<IAluguelRepository, AluguelRepository>();
                services.AddTransient<IClienteRepository, ClienteRepository>();
                services.AddTransient<IFilmeRepository, FilmeRepository>();
                services.AddTransient<IFuncionarioRepository, FuncionarioRepository>();
                services.AddTransient<IAluguelBusiness, AluguelBusiness>();
                services.AddTransient<IClienteBusiness, ClienteBusiness>();
                services.AddTransient<IFilmeBusiness, FilmeBusiness>();
                services.AddTransient<IFuncionarioBusiness, FuncionarioBusiness>();
                services.AddTransient<IControlePromocionalBusiness, ControlePromocionalBusiness>();
                services.AddTransient<IControlePromocionalRepository, ControlePromocionalRepository>();
                services.AddSingleton(MapConfiguration.Config());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
