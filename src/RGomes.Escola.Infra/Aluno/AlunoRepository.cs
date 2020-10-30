namespace RGomes.Escola.Infra.Aluno
{
    using System.Collections.Generic;
    using System.Linq;
    using RGomes.Escola.Domain.Aluno;

    public class AlunoRepository : IAlunoRepository
    {
        private readonly List<Aluno> alunos = new List<Aluno>();
        public Aluno BuscarPorCPF(CPF cpf)
        {
            return this.alunos.FirstOrDefault(aluno => aluno.CPF.Numero.Equals(cpf.Numero));
        }

        public IEnumerable<Aluno> ListarTodosAlunosMatriculados()
        {
            return this.alunos;
        }

        public void Matricular(Aluno aluno)
        {
            this.alunos.Add(aluno);
        }
    }
}