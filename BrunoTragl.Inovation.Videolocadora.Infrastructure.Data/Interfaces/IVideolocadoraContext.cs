using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace BrunoTragl.Inovation.Videolocadora.Infrastructure.Data.Interfaces
{
    public interface IVideolocadoraContext
    {
        DbSet<Aluguel> Aluguel { get; set; }
        DbSet<Cliente> Cliente { get; set; }
        DbSet<Filme> Filme { get; set; }
        DbSet<Funcionario> Funcionario { get; set; }
        DbSet<ControlePromocional> ControlePromocional { get; set; }
        int SaveChanges();
    }
}
