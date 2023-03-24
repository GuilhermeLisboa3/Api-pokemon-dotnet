using UserLoginProject.Application.DTOS.Output;
using UserLoginProject.Application.Interfaces.Pokemons;
using UserLoginProject.Domain.Interface.Pokemons;

namespace UserLoginProject.Application.Service.Pokemons
{
    public class ListPokemonsService : IListPokemonsService
    {
        private readonly IListPokemons _listPokemons;
        public ListPokemonsService(IListPokemons listPokemons)
        {
            _listPokemons = listPokemons;
        }

        public async Task<List<PokemonOutput>> List(Guid accountId) {
            var pokemons = await _listPokemons.List(accountId);
            List<PokemonOutput> listPokemons = new List<PokemonOutput>();
            foreach (var pokemon in pokemons) { 
                listPokemons.Add(PokemonOutput.FromEntity(pokemon));
            }
                return listPokemons;
        }
    }
}
