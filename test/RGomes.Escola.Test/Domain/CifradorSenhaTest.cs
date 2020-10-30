using RGomes.Escola.Domain.Aluno;
using RGomes.Escola.Infra.Aluno;
using Xunit;

namespace RGomes.Escola.Domain.Test
{
    public class CifradorSenhaTest
    {
        [Fact]
        public void Deve_Validar_Senha_Cifrada()
        {
            ICifradorSenha service = new CifradorSenha();
            var senha = "-123@";
            var senhaCifrada = service.Cifrar(senha);
            var iguais = service.Validar(senhaCifrada, senha);
            Assert.True(iguais);
        }

        [Fact]
        public void Nao_Deve_Validar_Senhas_Cifradas_Diferentes()
        {
            ICifradorSenha service = new CifradorSenha();
            var senha = "ABCDOPRE";
            var iguais = service.Validar("ABCDOPRE000000", senha);
            Assert.False(iguais);
        }

    }
}
