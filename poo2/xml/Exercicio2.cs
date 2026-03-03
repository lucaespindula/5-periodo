using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

public class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
}

public class Exercicio2
{
    public static void Executar()
    {
        List<Produto> produtos = new List<Produto>
        {
            new Produto { Nome = "Jogo GTA VI", Preco = 1000.00 },
            new Produto { Nome = "Controle", Preco = 140.50 },
            new Produto { Nome = "Fone Gamer", Preco = 230.00 }
        };

        XmlSerializer serializer = new XmlSerializer(typeof(List<Produto>));

        using (StreamWriter writer = new StreamWriter("produtos.xml"))
        {
            serializer.Serialize(writer, produtos);
        }

        Console.WriteLine("Arquivo produtos.xml criado!");
        Console.WriteLine();
        Console.WriteLine(File.ReadAllText("produtos.xml"));
    }
}