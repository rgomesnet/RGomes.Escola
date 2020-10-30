namespace RGomes.Escola.Application.Aluno
{
    using RGomes.Escola.Domain.Aluno;

    public interface IEnviarEmailIndicacao
    {
        void EnviarPara(Aluno indicado);
    }
}
