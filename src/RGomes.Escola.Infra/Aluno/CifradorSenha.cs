namespace RGomes.Escola.Infra.Aluno
{
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using RGomes.Escola.Domain.Aluno;

    public class CifradorSenha : ICifradorSenha
    {
        private readonly MD5 md5Hash = MD5.Create();

        public string Cifrar(string senha)
        {
            var senhaCifrada = CifrarSenha(senha);
            return senhaCifrada;
        }

        public bool Validar(string senhaCifrada, string senha)
        {
            var senhaCifradaComparacao = CifrarSenha(senha);
            return senhaCifradaComparacao.Equals(senhaCifrada);
        }

        private string CifrarSenha(string senha)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));

            var sb = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sb.Append(data[i].ToString("x2"));
            }

            return sb.ToString();
        }
    }
}
