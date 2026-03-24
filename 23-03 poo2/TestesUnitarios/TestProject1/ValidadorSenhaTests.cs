using Xunit;
using TestesUnitarios;

namespace TestProject1
{
    public class ValidadorSenhaTests
    {
        [Fact]
        public void SenhaValida()
        {
            var v = new ValidadorSenha();
            Assert.True(v.EhValida("Senha123"));
        }

        [Fact]
        public void ApenasNumeros()
        {
            var v = new ValidadorSenha();
            Assert.False(v.EhValida("12345678"));
        }

        [Fact]
        public void SenhaVazia()
        {
            var v = new ValidadorSenha();
            Assert.False(v.EhValida(""));
        }

        [Fact]
        public void ApenasLetras()
        {
            var v = new ValidadorSenha();
            Assert.False(v.EhValida("abcdEFGH"));
        }
    }
}