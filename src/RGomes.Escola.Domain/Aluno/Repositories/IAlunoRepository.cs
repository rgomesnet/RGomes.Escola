using System.Collections.Generic;

namespace RGomes.Escola.Domain.Aluno
{
    public interface IAlunoRepository
    {
        void Matricular(Aluno aluno);
        Aluno BuscarPorCPF(CPF cpf);
        IEnumerable<Aluno> ListarTodosAlunosMatriculados();
    }
}