using UserLoginProject.Domain.Contracts.Repository.Pokemons;
using UserLoginProject.Domain.Entities;
using UserLoginProject.Domain.Interface.Pokemons;

namespace UserLoginProject.Domain.UseCase.Pokemons
{
    public class AddPokemonUseCase : IAddPokemon
    {
        private readonly CheckPokemon _checkPokemon;
        private readonly AddPokemon _addPokemon;
        public AddPokemonUseCase(CheckPokemon checkPokemon, AddPokemon addPokemon)
        {
            _checkPokemon = checkPokemon;
            _addPokemon = addPokemon;
        }
        public async Task<Pokemon?> Add(Pokemon pokemonModel, Guid accountId) {
            var exists = await _checkPokemon.Check(pokemonModel.IdPokemon, accountId);
            if (!exists) {
                return await _addPokemon.Add(pokemonModel, accountId);
            }
            return null;
        }
    }
}
