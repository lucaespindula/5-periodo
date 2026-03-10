using Newtonsoft.Json;
using System;

public static class Exercicio1
{
    public static void Rodar()
    {
        Livro livro = new Livro
        {
            Titulo = "Biblia",
            Autor = "Homem",
            Ano = 100
        };

        string json = JsonConvert.SerializeObject(livro, Formatting.Indented);
        Console.WriteLine(json);
    }
}

class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int Ano { get; set; }
}