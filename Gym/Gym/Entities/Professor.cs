using Gym.Enums;
using System.Collections.Generic;

namespace Gym.Entities
{
    public class Professor
    {
        protected Professor()
        {
        }

        public Professor(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
            Status = StatusProfessorEnum.Ativo;
            Alunos = new List<Aluno>();
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public StatusProfessorEnum Status { get; private set; }
        public List<Aluno> Alunos { get; private set; }
    }
}