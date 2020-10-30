using System;
using RGomes.Escola.Domain.Aluno;
using Xunit;

namespace RGomes.Escola.Domain.Test
{
    public class TelefoneTest
    {
        [Fact]
        public void Deve_Instanciar_Telefone_Valido()
        {
            var telefone = new Telefone("11", "988887777");
            Assert.Equal("11", telefone.DDD);
            Assert.Equal("988887777", telefone.Numero);
        }

        [Fact]
        public void Nao_Deve_Instanciar_Telefone_Valido()
        {
            Assert.Throws<ArgumentException>(() => new Telefone(string.Empty, "334455"));
        }
    }
}