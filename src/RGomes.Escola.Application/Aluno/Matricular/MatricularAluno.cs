
namespace RGomes.Escola.Application.Aluno.Matricular
{
    using RGomes.Escola.Domain.Aluno;

    public class MatricularAluno : IMatricularAluno
    {
        private readonly IAlunoRepository alunoRepository;

        public MatricularAluno(IAlunoRepository alunoRepository)
            => this.alunoRepository = alunoRepository;

        public void Executar(MatricularAlunoDTO dto)
        {
            var aluno = dto.AsAluno();
            this.alunoRepository.Matricular(aluno);
        }
    }
}