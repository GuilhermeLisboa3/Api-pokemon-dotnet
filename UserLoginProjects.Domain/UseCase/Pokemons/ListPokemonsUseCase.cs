using UserLoginProject.Domain.Contracts.Repository.Pokemons;
using UserLoginProject.Domain.Entities;
using UserLoginProject.Domain.Interface.Pokemons;

namespace UserLoginProject.Domain.UseCase.Pokemons
{
    public class ListPokemonsUseCase : IListPokemons
    {
        private readonly ListPokemonsRepo _listPokemonsRepo;
        public ListPokemonsUseCase(ListPokemonsRepo listPokemonsRepo)
        {
            _listPokemonsRepo = listPokemonsRepo;
        }
        public async Task<List<Pokemon>> List(Guid accountId) {
            return await _listPokemonsRepo.ListPokemon(accountId);
        }
    }
}
