using UserLoginProject.Domain.Entities;

namespace UserLoginProject.Domain.Contracts.Repository.Pokemons
{
    public interface AddPokemon
    {
        Task<Pokemon> Add(Pokemon pokemonModel, Guid accountId);
    }
}
