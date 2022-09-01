using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usando_API_Pokemon
{
    public interface IApiPokemon
    {
        public Task<object> Get();
    }
}
