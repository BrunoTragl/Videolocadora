using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrunoTragl.Inovation.Videolocadora.Infrastructure.Data.Configurations
{
    public class FuncionarioConfiguration : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("funcionario");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.Property(p => p.Nome).HasColumnType("VARCHAR(150)").IsRequired();
            builder.Property(p => p.Sobrenome).HasColumnType("VARCHAR(300)").IsRequired();
            builder.Property(p => p.Email).HasColumnType("VARCHAR(300)");
            builder.Property(p => p.Login).HasColumnType("VARCHAR(30)").IsRequired();
            builder.Property(p => p.Senha).HasColumnType("VARCHAR(30)").IsRequired();
            builder.Property(p => p.Cadastro).IsRequired();
        }
    }
}
