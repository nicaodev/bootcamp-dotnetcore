using Gym.EFConfigurations;
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
            mb.ApplyConfiguration(new AlunoConfig());
            mb.ApplyConfiguration(new ProfessorConfig());
            mb.ApplyConfiguration(new UnidadeConfig());
        }
    }
}