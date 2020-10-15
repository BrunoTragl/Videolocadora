using BrunoTragl.Inovation.Videolocadora.Application.Business;
using BrunoTragl.Inovation.Videolocadora.Application.Business.Interfaces;
using BrunoTragl.Inovation.Videolocadora.Infrastructure.Data;
using BrunoTragl.Inovation.Videolocadora.Infrastructure.Data.Interfaces;
using BrunoTragl.Inovation.Videolocadora.Infrastructure.Repository;
using BrunoTragl.Inovation.Videolocadora.Infrastructure.Repository.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BrunoTragl.Inovation.Videolocadora.Services.WebApi.IOC
{
    public static class DependencyInjection
    {
        public static void Container(IServiceCollection services)
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
        }
    }
}
