using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrunoTragl.Inovation.Videolocadora.Infrastructure.Data.Configurations
{
    public class FilmeConfiguration : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            builder.ToTable("filme");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Titulo).HasColumnType("VARCHAR(300)").IsRequired();
            builder.Property(p => p.Descricao).HasColumnType("VARCHAR(1000)").IsRequired();
            builder.Property(p => p.Valor).IsRequired();
            builder.Property(p => p.Cadastro).IsRequired();
        }
    }
}
