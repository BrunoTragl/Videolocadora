using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrunoTragl.Inovation.Videolocadora.Infrastructure.Data.Configurations
{
    public class AluguelConfiguration : IEntityTypeConfiguration<Aluguel>
    {
        public void Configure(EntityTypeBuilder<Aluguel> builder)
        {
            builder.ToTable("aluguel");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.HasOne(p => p.Cliente).WithOne(p => p.Aluguel).HasForeignKey<Aluguel>(p => p.ClienteId).IsRequired();
            builder.HasOne(p => p.Filme).WithOne(p => p.Aluguel).HasForeignKey<Aluguel>(p => p.FilmeId).IsRequired();
            builder.HasOne(p => p.Funcionario).WithOne(p => p.Aluguel).HasForeignKey<Aluguel>(p => p.FuncionarioId).IsRequired();
        }
    }
}
