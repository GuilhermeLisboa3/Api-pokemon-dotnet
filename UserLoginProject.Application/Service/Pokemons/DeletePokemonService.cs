using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLoginProject.Application.Interfaces.Pokemons;
using UserLoginProject.Domain.Interface.Pokemons;

namespace UserLoginProject.Application.Service.Pokemons
{
    public class DeletePokemonService : IDeletePokemonService
    {
        private readonly IDeletePokemon _deletePokemon;
        public DeletePokemonService(IDeletePokemon deletePokemon)
        {
            _deletePokemon = deletePokemon;
        }

        public async Task Delete(string idPokemon, Guid accountId)
        {
            await _deletePokemon.Delete(idPokemon, accountId);
        }
    }
}
