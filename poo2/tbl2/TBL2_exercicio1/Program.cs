using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PokeAPI.Models;

class Program
{
    static async Task Main()
    {
        Console.Write("Digite o nome do Pokémon: ");
        string nome = Console.ReadLine();

        using (HttpClient client = new HttpClient())
        {
            string url = "https://pokeapi.co/api/v2/pokemon/" + nome.ToLower();
            string json = await client.GetStringAsync(url);

            Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(json);

            Console.WriteLine("\nPokémon encontrado!");
            Console.WriteLine("Nome:   " + pokemon.Name);
            Console.WriteLine("Altura: " + pokemon.Height);
            Console.WriteLine("Peso:   " + pokemon.Weight);

            Console.Write("Tipos:  ");
            foreach (var t in pokemon.Types)
                Console.Write(t.Type.Name + " ");

            Console.WriteLine();
        }
    }
}