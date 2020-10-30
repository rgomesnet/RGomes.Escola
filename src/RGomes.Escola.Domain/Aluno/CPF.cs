namespace RGomes.Escola.Domain.Aluno
{
    using System;

    public class CPF
    {
        public CPF(string numero)
        {
            if (!numero.Matches(@"^\d{3}\.\d{3}\.\d{3}\-\d{2}$"))
            {
                throw new ArgumentException("O número do CPF não é um valor válido.");
            }

            this.Numero = numero;
        }

        public string Numero { get; }
    }
}
