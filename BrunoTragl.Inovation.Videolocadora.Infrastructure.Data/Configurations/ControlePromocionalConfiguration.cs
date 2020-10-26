using BrunoTragl.Inovation.Videolocadora.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BrunoTragl.Inovation.Videolocadora.Infrastructure.Data.Configurations
{
    public class ControlePromocionalConfiguration : IEntityTypeConfiguration<ControlePromocional>
    {
        public void Configure(EntityTypeBuilder<ControlePromocional> builder)
        {
            builder.ToTable("controle_promocional");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
        }
    }
}
