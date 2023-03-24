
using UserLoginProject.Application.DTOS.Input;
using UserLoginProject.Application.DTOS.Output;
using UserLoginProject.Application.Interfaces.Pokemons;
using UserLoginProject.Domain.Interface.Pokemons;

namespace UserLoginProject.Application.Service.Pokemons
{
    public class AddPokemonService : IAddPokemonService
    {
        private readonly IAddPokemon _addPokemon;
        public AddPokemonService(IAddPokemon addPokemon)
        {
            _addPokemon = addPokemon;
        }
        public async Task<PokemonOutput> Add(PokemonInput pokemonModel, Guid accountId)
        {
            var pokemonInput = pokemonModel.toEntity();
            var pokemon = await _addPokemon.Add(pokemonInput, accountId);
            if (pokemon != null) return PokemonOutput.FromEntity(pokemon);
            return null;
        }
    }
}
