namespace RGomes.Escola.Domain.Aluno
{
    using System;

    public class Email
    {
        public Email(string endereco)
        {
            if (!endereco.Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                throw new ArgumentException("O e-mail informado não é um valor válido.");
            }

            this.Endereco = endereco;
        }

        public string Endereco { get; }
    }
}