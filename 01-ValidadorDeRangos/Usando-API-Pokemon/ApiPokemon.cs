using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Usando_API_Pokemon
{
    public class ApiPokemon : IApiPokemon
    {
        private readonly HttpClient client = new HttpClient();
        public async Task<object> Get()
        {
            client.DefaultRequestHeaders.Accept.Clear();
            var stringTask = await client.GetFromJsonAsync<object>("https://pokeapi.co/api/v2/pokemon/ditto");
           return stringTask;
        }
    }
}
