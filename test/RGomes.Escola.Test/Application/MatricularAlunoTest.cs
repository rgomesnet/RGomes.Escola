using RGomes.Escola.Application.Aluno;
using RGomes.Escola.Application.Aluno.Matricular;
using RGomes.Escola.Domain.Aluno;
using RGomes.Escola.Infra.Aluno;
using Xunit;

namespace RGomes.Escola.Application.Test
{
    public class MatricularAlunoTest
    {
        [Fact]
        public void Deve_Matricular_Aluno()
        {
            IAlunoRepository alunoRepository = new AlunoRepository();
            IMatricularAluno useCase = new MatricularAluno(alunoRepository);
            
            var dto = new MatricularAlunoDTO("Fulano de Tal", "062.165.335-76", "fulanodetal@email.com");
            useCase.Executar(dto);
            var aluno = alunoRepository.BuscarPorCPF(new CPF("062.165.335-76"));

            Assert.Equal("Fulano de Tal", aluno.Nome);
            Assert.Equal("062.165.335-76", aluno.CPF.Numero);
            Assert.Equal("fulanodetal@email.com", aluno.Email.Endereco);
        }
    }
}