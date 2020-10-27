using Gym.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Gym.EFConfigurations
{
    public class ProfessorConfig : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.HasKey(a => a.Id);

            builder.HasMany(a => a.Alunos)
                 .WithOne(a => a.Professor)
                 .HasForeignKey(a => a.IdProfessor)
                 .OnDelete(DeleteBehavior.Restrict);
        }
    }
}