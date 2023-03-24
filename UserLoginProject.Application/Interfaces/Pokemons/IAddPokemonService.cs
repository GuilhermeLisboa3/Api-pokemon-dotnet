using UserLoginProject.Application.DTOS.Input;
using UserLoginProject.Application.DTOS.Output;

namespace UserLoginProject.Application.Interfaces.Pokemons
{
    public interface IAddPokemonService
    {
        Task<PokemonOutput> Add(PokemonInput pokemonModel, Guid accountId);
    }
}
