namespace RGomes.Escola.Domain.Aluno
{
    using System.Collections.Generic;

    public class AlunoBuilder
    {
        private string nome;
        private string cpf;
        private string email;
        private IList<Telefone> telefones = new List<Telefone>();

        public AlunoBuilder Nome(string nome)
        {
            this.nome = nome;
            return this;
        }

        public AlunoBuilder CPF(string cpf)
        {
            this.cpf = cpf;
            return this;
        }

        public AlunoBuilder Email(string email)
        {
            this.email = email;
            return this;
        }

        public AlunoBuilder Telefone(string ddd, string numero)
        {
            telefones.Add(new Telefone(ddd, numero));
            return this;
        }

        public Aluno Build()
        {
            var aluno = new Aluno(this.nome, new CPF(this.cpf), new Email(this.email));

            foreach (var telefone in this.telefones)
            {
                aluno.Adicionar(telefone);
            }

            return aluno;
        }
    }
}