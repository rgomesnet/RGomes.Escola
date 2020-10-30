namespace RGomes.Escola.Application.Aluno
{
    using RGomes.Escola.Domain.Aluno;

    internal static class MatricularAlunoDTOExtensions
    {
        public static Aluno AsAluno(this MatricularAlunoDTO dto)
        {
            var builder = new AlunoBuilder();
            return builder.CPF(dto.CPF)
                          .Nome(dto.Nome)
                          .Email(dto.Email)
                          .Build();
        }
    }
}