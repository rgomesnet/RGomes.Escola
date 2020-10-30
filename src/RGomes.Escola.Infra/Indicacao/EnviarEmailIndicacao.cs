namespace RGomes.Escola.Infra.Aluno
{
    using System;
    using RGomes.Escola.Application.Aluno;
    using RGomes.Escola.Domain.Aluno;

    public class EnviarEmailIndicacao : IEnviarEmailIndicacao
    {
        public void EnviarPara(Aluno indicado)
        {
            Console.WriteLine($"Email enviado para {indicado.Nome}");
        }
    }
}