using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

public static class Exercicio3
{
    public static void Rodar()
    {
        List<Carro> carros = new List<Carro>()
        {
            new Carro { Marca = "Volkswagen", Modelo = "Gol G5", Ano = 2012 },
            new Carro { Marca = "Chevrolet", Modelo = "Corsa", Ano = 2013 },
            new Carro { Marca = "Ford", Modelo = "Ka", Ano = 2016 }
        };

        string json = JsonConvert.SerializeObject(carros, Formatting.Indented);
        File.WriteAllText("carros.json", json);

        string jsonLido = File.ReadAllText("carros.json");
        List<Carro> carrosLidos = JsonConvert.DeserializeObject<List<Carro>>(jsonLido);

        foreach (var c in carrosLidos)
        {
            Console.WriteLine(c.Marca);
            Console.WriteLine(c.Modelo);
            Console.WriteLine(c.Ano);
            Console.WriteLine();
        }
    }
}

class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }
}