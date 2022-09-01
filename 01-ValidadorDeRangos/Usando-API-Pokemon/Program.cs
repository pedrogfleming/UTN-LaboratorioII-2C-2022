namespace Usando_API_Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IApiPokemon apiPokemon = new ApiPokemon();
            var result = apiPokemon.Get().Result;
            
        }
    }
}