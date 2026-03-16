// Services/PokemonService.cs
// Essa camada contém a LÓGICA do sistema.
// Responsabilidades:
//   - Saber o endereço da API
//   - Fazer a requisição HTTP (buscar dados na internet)
//   - Converter o JSON recebido em um objeto Pokemon

using Newtonsoft.Json;

public class PokemonService
{
    // HttpClient é a classe do C# usada para fazer chamadas HTTP (acessar URLs)
    private HttpClient client = new HttpClient();

    // Método assíncrono: usa "async/await" porque a chamada de rede pode demorar
    // Não queremos travar o programa enquanto espera a resposta da internet
    public async Task<Pokemon> BuscarPokemon(string nome)
    {
        // Monta a URL com o nome do pokémon que o usuário digitou
        string url = $"https://pokeapi.co/api/v2/pokemon/{nome}";

        // Faz a chamada para a API e recebe o JSON como texto
        string json = await client.GetStringAsync(url);

        // Converte o texto JSON em um objeto da classe Pokemon
        // O Newtonsoft.Json lê os campos do JSON e preenche as propriedades
        return JsonConvert.DeserializeObject<Pokemon>(json);
    }
}