namespace RGomes.Escola.Domain.Aluno
{
    using System;

    public class Telefone
    {
        public Telefone(string ddd, string numero)
        {
            if (!ddd.Matches(@"[0-9]{2}"))
            {
                throw new ArgumentException("O DDD não é um valor válido.");
            }

            if (!numero.Matches(@"[0-9]{4,5}-?[0-9]{4}"))
            {
                throw new ArgumentException("O número do telefone não é um valor válido.");
            }

            this.DDD = ddd;
            this.Numero = numero;
        }

        public string DDD { get; }
        public string Numero { get; }
    }
}