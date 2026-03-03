using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;

public class Food
{
    public string Nome { get; set; }
    public string Preco { get; set; }
}

public class Exercicio4
{
    public static async Task Executar()
    {
        string url = "https://www.w3schools.com/xml/simple.xml";

        using HttpClient client = new HttpClient();

        var response = await client.GetStringAsync(url);

        var doc = XDocument.Parse(response);

        var foods = doc.Descendants("food");

        List<Food> lista = new List<Food>();

        foreach (var food in foods)
        {
            string nome = food.Element("name")?.Value;
            string preco = food.Element("price")?.Value;

            lista.Add(new Food
            {
                Nome = nome,
                Preco = preco
            });
        }

        foreach (var item in lista)
        {
            Console.WriteLine($"Nome: {item.Nome}");
            Console.WriteLine($"Preço: {item.Preco}");
        }
    }
}