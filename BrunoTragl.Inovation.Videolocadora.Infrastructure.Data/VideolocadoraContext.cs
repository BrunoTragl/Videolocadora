using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using BrunoTragl.Inovation.Videolocadora.Infrastructure.Data.Configurations;
using BrunoTragl.Inovation.Videolocadora.Infrastructure.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BrunoTragl.Inovation.Videolocadora.Infrastructure.Data
{
    public class VideolocadoraContext : DbContext, IVideolocadoraContext
    {
        private readonly IConfiguration _configuration;
        public VideolocadoraContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Aluguel> Aluguel { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Filme> Filme { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("VideolocadoraContext"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AluguelConfiguration());
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new FilmeConfiguration());
            modelBuilder.ApplyConfiguration(new FuncionarioConfiguration());
        }
    }
}
