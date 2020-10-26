using Gym.Entities;
using Microsoft.EntityFrameworkCore;

namespace Gym.Persistence
{
    public class GymDbContext : DbContext
    {
        public GymDbContext(DbContextOptions<GymDbContext> options) : base(options)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Unidade> Unidades { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Aluno>()
                .HasKey(a => a.Id);

            mb.Entity<Professor>()
                .HasKey(a => a.Id);

            mb.Entity<Professor>()
                .HasMany(a => a.Alunos)
                .WithOne(a => a.Professor)
                .HasForeignKey(a => a.IdProfessor)
                .OnDelete(DeleteBehavior.Restrict);

            mb.Entity<Unidade>()
                .HasKey(a => a.Id);

            mb.Entity<Unidade>()
                .HasMany(u => u.Alunos)
                .WithOne(a => a.Unidade)
                .HasForeignKey(a => a.IdUnidade)
                .OnDelete(DeleteBehavior.Restrict);

            mb.Entity<Unidade>()
               .HasMany(u => u.Professores)
               .WithOne(a => a.Unidade)
               .HasForeignKey(a => a.IdUnidade)
               .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
