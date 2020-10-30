using System;
using RGomes.Escola.Domain.Aluno;
using Xunit;

namespace RGomes.Escola.Domain.Test
{
    public class EmailTest
    {
        [Fact]
        public void Deve_Instanciar_Email_Valido()
        {
            var email = new Email("fulanodetal@email.com");
            Assert.Equal("fulanodetal@email.com", email.Endereco);
        }

        [Fact]
        public void Nao_Deve_Instanciar_Email_Valido()
        {
            Assert.Throws<ArgumentException>(() => new Email("fulanodetal@email"));
        }

        [Fact]
        public void Nao_Deve_Instanciar_Email_Quando_Valor_Nulo()
        {
            Assert.Throws<ArgumentException>(() => new Email(null));
        }
    }
}
