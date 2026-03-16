using Newtonsoft.Json.Linq;
using System;

public static class Exercicio4
{
    public static void Rodar()
    {
        string json = @"{ 'Servidor': 'localhost', 'Porta': 5500, 'Usuario': 'lucas' }";

        JObject obj = JObject.Parse(json);

        Console.WriteLine(obj["Servidor"]);
        Console.WriteLine(obj["Porta"]);
        Console.WriteLine(obj["Usuario"]);

        obj["Porta"] = 5501;

        Console.WriteLine(obj.ToString());
    }
}