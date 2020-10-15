using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrunoTragl.Inovation.Videolocadora.Infrastructure.Data.Configurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("cliente");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Nome).HasColumnType("VARCHAR(150)").IsRequired();
            builder.Property(p => p.Sobrenome).HasColumnType("VARCHAR(300)").IsRequired();
            builder.Property(p => p.Telefone).HasColumnType("VARCHAR(15)");
            builder.Property(p => p.Email).HasColumnType("VARCHAR(300)");
            builder.Property(p => p.Cadastro).IsRequired();
        }
    }
}
