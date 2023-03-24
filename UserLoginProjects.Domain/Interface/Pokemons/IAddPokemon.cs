using UserLoginProject.Domain.Entities;

namespace UserLoginProject.Domain.Interface.Pokemons
{
    public interface IAddPokemon
    {
        Task<Pokemon?> Add(Pokemon pokemonModel, Guid accountId);
    }
}
