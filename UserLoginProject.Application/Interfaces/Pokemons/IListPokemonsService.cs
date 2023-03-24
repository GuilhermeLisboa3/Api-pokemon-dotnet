using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLoginProject.Application.DTOS.Output;

namespace UserLoginProject.Application.Interfaces.Pokemons
{
    public interface IListPokemonsService
    {
        Task<List<PokemonOutput>> List(Guid accountId);
    }
}
