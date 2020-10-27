using Gym.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gym.EFConfigurations
{
    public class UnidadeConfig : IEntityTypeConfiguration<Unidade>
    {
        public void Configure(EntityTypeBuilder<Unidade> builder)
        {
            builder.HasKey(a => a.Id);

            builder.HasMany(u => u.Alunos)
                .WithOne(a => a.Unidade)
                .HasForeignKey(a => a.IdUnidade)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(u => u.Professores)
               .WithOne(a => a.Unidade)
               .HasForeignKey(a => a.IdUnidade)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}