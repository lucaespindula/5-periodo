using System;
using ClassLibrary;

class Program
{
    static void Main()
    {
        Conversor conv = new Conversor();

        Console.Write("Digite o valor em reais: ");
        double valor = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a taxa de cmbio: ");
        double taxa = Convert.ToDouble(Console.ReadLine());

        double resultado = conv.ConverterMoeda(valor, taxa);

        Console.WriteLine("Valor convertido: " + resultado);

        Console.ReadLine();
    }
}
