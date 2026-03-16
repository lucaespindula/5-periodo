using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TBL2_exercicio1._1.Models;

namespace TBL2_exercicio1._1.Services
{
    public class PokemonService
    {
        private readonly HttpClient _client;

        public PokemonService()
        {
            _client = new HttpClient();
        }
        public async Task<Pokemon> BuscarPokemon(string nome)
        {
            try
            {
                string url = "https://pokeapi.co/api/v2/pokemon/" + nome.ToLower().Trim();
                string json = await _client.GetStringAsync(url);
                Pokemon pokemon = JsonConvert.DeserializeObject<Pokemon>(json);
                return pokemon;
            }
            catch (HttpRequestException)
            {
                Console.WriteLine("Pokemon não encontrado.");
                return null;
            }
        }
        public async Task<Pokemon> BuscarPokemonAleatorio()
        {
            Random random = new Random();
            int id = random.Next(1, 1026);
            Console.WriteLine("Pokemon aleatório: ID " + id);
            return await BuscarPokemon(id.ToString());
        }
    }
}