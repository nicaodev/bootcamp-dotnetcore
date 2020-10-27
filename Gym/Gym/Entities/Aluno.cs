using Gym.Enums;
using System;

namespace Gym.Entities
{
    public class Aluno
    {
        protected Aluno()
        {
        }

        public Aluno(string nome, string endereco, DateTime dataNascimento)
        {
            Nome = nome;
            Endereco = endereco;
            DataNascimento = dataNascimento;
            Status = StatusAlunoEnum.Ativo;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public StatusAlunoEnum Status { get; private set; }

        // Propriedades de navegação no banco de dados.
        public int IdUnidade { get; private set; }
        public Unidade Unidade { get; private set; }

        public int IdProfessor { get; private set; }
        public Professor Professor { get; private set; }

        public void tornaInativo()
        {
            if (Status != StatusAlunoEnum.Ativo)
                throw new Exception("Já não está ativo!");

            Status = StatusAlunoEnum.Inativo;
        }
    }
}