using System;
using System.Threading.Tasks;
using TBL2_exercicio1._1.Models;
using TBL2_exercicio1._1.Services;

class Program
{
    static async Task Main()
    {
        PokemonService service = new PokemonService();
        Pokemon pokemon = null;

        Console.WriteLine("API PokéAPI");
        Console.WriteLine("1. Buscar por nome");
        Console.WriteLine("2. Pokemon Aleatório");
        Console.Write("Escolha: ");
        string opcao = Console.ReadLine();

        if (opcao == "1")
        {
            Console.Write("Digite o nome do Pokemon: ");
            string nome = Console.ReadLine();
            pokemon = await service.BuscarPokemon(nome);
        }
        else if (opcao == "2")
        {
            pokemon = await service.BuscarPokemonAleatorio();
        }
        else
        {
            Console.WriteLine("Opção inválida.");
            return;
        }

        if (pokemon != null)
        {
            Console.WriteLine("\nPokemon encontrado!");
            Console.WriteLine("ID:              " + pokemon.Id);
            Console.WriteLine("Nome:            " + pokemon.Name);
            Console.WriteLine("Altura:          " + pokemon.Height);
            Console.WriteLine("Peso:            " + pokemon.Weight);
            Console.WriteLine("Base Experience: " + pokemon.BaseExperience);

            Console.Write("Tipos:  ");
            foreach (var t in pokemon.Types)
                Console.Write(t.Type.Name + " ");

            Console.WriteLine();
        }
    }
}