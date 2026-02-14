namespace ClassLibrary
{
    public class Conversor
    {
        public double CelsiusParaFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public double MetrosParaQuilometros(double metros)
        {
            return metros / 1000;
        }
        public double ConverterMoeda(double valor, double taxa)
        {
            return valor * taxa;
        }
    }
}
