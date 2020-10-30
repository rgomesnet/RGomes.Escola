using System;
using System.Linq;
using RGomes.Escola.Domain.Aluno;
using Xunit;

namespace RGomes.Escola.Domain.Test
{
    public class AlunoTest
    {
        [Fact]
        public void Deve_Instanciar_Aluno_Usando_Builder()
        {
            var builder = new AlunoBuilder();
            var aluno = builder.CPF("062.165.335-76")
                               .Email("fulanodetal@email.com")
                               .Nome("Fulano de Tal")
                               .Telefone("11", "988887777")
                               .Telefone("11", "44448888")
                               .Build();

            Assert.Equal("Fulano de Tal", aluno.Nome);
            Assert.Equal("062.165.335-76", aluno.CPF.Numero);
            Assert.Equal("fulanodetal@email.com", aluno.Email.Endereco);
            Assert.Equal("11", aluno.Telefones.First().DDD);
            Assert.Equal("988887777", aluno.Telefones.First().Numero);
            Assert.Equal("11", aluno.Telefones.Skip(1).First().DDD);
            Assert.Equal("44448888", aluno.Telefones.Skip(1).First().Numero);
        }

        [Fact]
        public void Nao_Deve_Instanciar_Aluno_Usando_Builder()
        {
            var builder = new AlunoBuilder();

            var execption =
                Assert.Throws<ArgumentException>(() => builder.CPF("062.165.335-76")
                                                              .Email("fulanodetalemail.com")
                                                              .Nome("Fulano de Tal")
                                                              .Telefone("11", "988887777")
                                                              .Telefone("11", "44448888")
                                                              .Build());

            Assert.Equal("O e-mail informado não é um valor válido.", execption.Message);
        }
    }
}