using System;
using BibliotecaValidacoes;

class Program
{
    static void Main()
    {
        Validador val = new Validador();

        Console.Write("Digite CPF: ");
        string cpf = Console.ReadLine();

        bool valido = val.ValidadorCPF(cpf);

        Console.WriteLine("CPF válido: " + valido);

        Console.ReadLine();
    }
}
