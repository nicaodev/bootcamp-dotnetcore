using Gym.Enums;
using System;

namespace Gym.Entities
{
    public class Aluno
    {
        protected Aluno()
        {
        }

        public Aluno(string nome, int endereco, DateTime dataNascimento)
        {
            Nome = nome;
            Endereco = endereco;
            DataNascimento = dataNascimento;
            Status = StatusAlunoEnum.Ativo;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int Endereco { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public StatusAlunoEnum Status { get; private set; }
    }
}