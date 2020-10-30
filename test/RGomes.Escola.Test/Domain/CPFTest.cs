using System;
using RGomes.Escola.Domain.Aluno;
using Xunit;

namespace RGomes.Escola.Domain.Test
{
    public class CPFTest
    {
        [Fact]
        public void Deve_Instanciar_CPF_Valido()
        {
            var cpf = new CPF("062.165.335-76");
            Assert.Equal("062.165.335-76", cpf.Numero);
        }

        [Fact]
        public void Nao_Deve_Instanciar_CPF_Valido()
        {
            Assert.Throws<ArgumentException>(() => new CPF("fulanodetal@email"));
        }
    }
}
