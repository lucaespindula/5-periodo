using Xunit;
using TestesUnitarios;

namespace TestProject1
{
    public class DescontoServiceTests
    {
        [Theory]
        [InlineData(100, 10, 90)]
        [InlineData(200, 50, 100)]
        [InlineData(80, 0, 80)]
        public void DescontoCorreto(double valor, double perc, double esperado)
        {
            var s = new DescontoService();

            var r = s.AplicarDesconto(valor, perc);

            Assert.Equal(esperado, r);
        }

        [Fact]
        public void ValorNegativo()
        {
            var s = new DescontoService();
            Assert.Throws<ArgumentException>(() => s.AplicarDesconto(-1, 10));
        }

        [Fact]
        public void PercentualNegativo()
        {
            var s = new DescontoService();
            Assert.Throws<ArgumentException>(() => s.AplicarDesconto(100, -1));
        }

        [Fact]
        public void PercentualMaior100()
        {
            var s = new DescontoService();
            Assert.Throws<ArgumentException>(() => s.AplicarDesconto(100, 200));
        }
    }
}