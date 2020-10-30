namespace RGomes.Escola.Application.Aluno
{
    public class MatricularAlunoDTO
    {
        public MatricularAlunoDTO(string nome, string cpf, string email)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Email = email;
        }

        public string Nome { get; }
        public string CPF { get; }
        public string Email { get; }
    }
}