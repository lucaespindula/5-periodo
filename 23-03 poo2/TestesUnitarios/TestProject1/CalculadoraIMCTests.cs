using Xunit;
using TestesUnitarios;

namespace TestProject1
{
    public class CalculadoraIMCTests
    {
        [Fact]
        public void CalculoCorreto()
        {
            var calc = new CalculadoraIMC();
            var r = calc.Calcular(70, 1.75);

            Assert.Equal(22.86, r, 2);
        }

        [Fact]
        public void AbaixoPeso()
        {
            var calc = new CalculadoraIMC();
            Assert.Equal("Abaixo do peso", calc.Classificar(17));
        }

        [Fact]
        public void Sobrepeso()
        {
            var calc = new CalculadoraIMC();
            Assert.Equal("Sobrepeso", calc.Classificar(26));
        }

        [Fact]
        public void ExcecaoAltura()
        {
            var calc = new CalculadoraIMC();

            Assert.Throws<ArgumentException>(() => calc.Calcular(70, 0));
        }
    }
}