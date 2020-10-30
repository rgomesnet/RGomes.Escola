namespace RGomes.Escola.Domain.Aluno
{
    using System.Collections.Generic;

    public class Aluno
    {
        private readonly IList<Telefone> telefones;

        public Aluno(string nome, CPF cpf, Email email)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Email = email;
            this.telefones = new List<Telefone>();
        }
        public string Nome { get; }

        public CPF CPF { get; }

        public Email Email { get; }

        public IEnumerable<Telefone> Telefones
            => this.telefones;

        public void Adicionar(Telefone telefone)
        {
            this.telefones.Add(telefone);
        }
    }
}