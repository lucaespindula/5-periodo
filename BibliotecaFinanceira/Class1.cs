namespace BibliotecaFinanceira
{
    public class CalculadoraJuros
    {
        public double JurosSimples(double capital, double taxa, double tempo)
        {
            return capital * taxa * tempo;
        }

        internal double CalculoInterno(double valor)
        {
            return valor * 2;
        }
    }
}
