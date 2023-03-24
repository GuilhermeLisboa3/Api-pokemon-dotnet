using Microsoft.EntityFrameworkCore;
using UserLoginProject.Domain.Contracts.Repository.Pokemons;
using UserLoginProject.Domain.Entities;
using UserLoginProject.Infra.Database.Helpers;

namespace UserLoginProject.Infra.Database.Repositories
{
    public class PokemonRepository : CheckPokemon, AddPokemon, ListPokemonsRepo, DeletePokemon
    {
        private readonly DataContext _context;
        public PokemonRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Pokemon> Add(Pokemon pokemonModel, Guid accountId)
        {
            pokemonModel.Id = Guid.NewGuid();
            pokemonModel.AccountId = accountId;
            var pokemon = await _context.Pokemon.AddAsync(pokemonModel);
            await _context.SaveChangesAsync();
            return pokemonModel;
        }

        public async Task<bool> Check(string idPokemon, Guid accountId)
        {
            var exist = _context.Pokemon.SingleOrDefault(pokemon => pokemon.IdPokemon == idPokemon && pokemon.AccountId == accountId);
            return exist != null ? true : false;
        }

        public async Task Delete(string idPokemon, Guid accountId)
        {
            var pokemon = _context.Pokemon.SingleOrDefault(pokemon => pokemon.IdPokemon == idPokemon && pokemon.AccountId == accountId);
            _context.Entry(pokemon).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public Task<List<Pokemon>> ListPokemon(Guid accountId)
        {
            return _context.Pokemon.Where(pokemon => pokemon.AccountId == accountId).ToListAsync();
        }
    }
}
