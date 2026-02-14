using System;
using BibliotecaFinanceira;

class Program
{
    static void Main()
    {
        CalculadoraJuros calc = new CalculadoraJuros();

        double juros = calc.JurosSimples(1000, 0.05, 2);

        Console.WriteLine("Juros: " + juros);

        Console.ReadLine();
    }
}


//método internal nao aparece pq so podem ser acessados dentro do mesmo assembly.