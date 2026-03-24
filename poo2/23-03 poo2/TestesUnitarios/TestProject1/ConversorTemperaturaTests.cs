using Xunit;
using TestesUnitarios;

namespace TestProject1
{
    public class ConversorTemperaturaTests
    {
        [Fact]
        public void CtoF_0()
        {
            var c = new ConversorTemperatura();
            Assert.Equal(32, c.CelsiusParaFahrenheit(0));
        }

        [Fact]
        public void CtoF_100()
        {
            var c = new ConversorTemperatura();
            Assert.Equal(212, c.CelsiusParaFahrenheit(100));
        }

        [Fact]
        public void FtoC_32()
        {
            var c = new ConversorTemperatura();
            Assert.Equal(0, c.FahrenheitParaCelsius(32));
        }

        [Fact]
        public void FtoC_212()
        {
            var c = new ConversorTemperatura();
            Assert.Equal(100, c.FahrenheitParaCelsius(212));
        }
    }
}