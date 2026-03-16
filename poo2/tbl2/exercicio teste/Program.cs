// Program.cs
// Essa é a camada de INTERFACE COM O USUÁRIO.
// Responsabilidades:
//   - Perguntar ao usuário o que ele quer
//   - Chamar o Service para buscar os dados
//   - Mostrar o resultado na tela
//
// O Program NÃO deve saber como a API funciona.
// Ele só conversa com o usuário e delega o trabalho para o Service.

using System.ComponentModel;

class Program
{
    static async Task Main()
    {
        // Cria uma instância do serviço que sabe buscar pokémons
        PokemonService service = new PokemonService();

        // Pede o nome ao usuário
        Console.Write("Digite o nome do pokemon: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Buscando...");

        // Chama o serviço passando o nome digitado
        // O "await" espera a resposta da internet sem travar o programa
        Pokemon p = await service.BuscarPokemon(nome);

        // Exibe os dados recebidos
        Console.WriteLine("=============================");
        Console.WriteLine("Nome:   " + p.Name);
        Console.WriteLine("Altura: " + p.Height + " (x10 cm)");
        Console.WriteLine("Peso:   " + p.Weight + " (x100 g)");
        Console.WriteLine("=============================");
    }
}