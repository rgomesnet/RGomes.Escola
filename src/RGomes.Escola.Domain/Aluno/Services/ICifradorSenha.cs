namespace RGomes.Escola.Domain.Aluno
{
    public interface ICifradorSenha
    {
        string Cifrar(string senha);
        bool Validar(string senhaCifrada, string senha);
    }
}