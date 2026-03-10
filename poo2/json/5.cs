using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public static class Exercicio5
{
    public static void Rodar()
    {
        List<Produto> produtos = new List<Produto>()
        {
            new Produto { Id = 1, Nome = "Notebook", Preco = 3900, Estoque = 10, Fornecedor = "Samsung", CodigoInterno = "1" },
            new Produto { Id = 2, Nome = "Mouse", Preco = 120, Estoque = 30, Fornecedor = null, CodigoInterno = "2" },
            new Produto { Id = 3, Nome = "Teclado", Preco = 150, Estoque = 30, Fornecedor = "Redragon", CodigoInterno = "3" }
        };

        string json = JsonConvert.SerializeObject(
            produtos,
            Formatting.Indented,
            new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore }
        );

        File.WriteAllText("produtos.json", json);
        Console.WriteLine(json);

        try
        {
            string jsonLido = File.ReadAllText("produtos.json");
            List<Produto> listaDesserializada = JsonConvert.DeserializeObject<List<Produto>>(jsonLido);

            Console.WriteLine("\nProdutos lidos do JSON:\n");
            foreach (var p in listaDesserializada)
            {
                Console.WriteLine($"Id: {p.Id}");
                Console.WriteLine($"Nome: {p.Nome}");
                Console.WriteLine($"Preço: {p.Preco}");
                Console.WriteLine($"Estoque: {p.Estoque}");
                if (p.Fornecedor != null)
                    Console.WriteLine($"Fornecedor: {p.Fornecedor}");
                Console.WriteLine();
            }
        }
        catch (JsonSerializationException ex)
        {
            Console.WriteLine("Erro na desserialização: " + ex.Message);
        }
    }
}

class Produto
{
    [JsonProperty(Order = 1)]
    public int Id { get; set; }

    [JsonProperty("product_name", Order = 2, Required = Required.Always)]
    public string Nome { get; set; }

    [JsonProperty("product_price", Order = 3, Required = Required.Always)]
    public double Preco { get; set; }

    [JsonProperty(Order = 4)]
    public int Estoque { get; set; }

    [JsonProperty(Order = 5, NullValueHandling = NullValueHandling.Ignore)]
    public string Fornecedor { get; set; }

    [JsonIgnore]
    public string CodigoInterno { get; set; }
}