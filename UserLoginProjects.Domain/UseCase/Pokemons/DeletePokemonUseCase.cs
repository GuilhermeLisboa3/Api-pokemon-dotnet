using UserLoginProject.Domain.Contracts.Repository.Pokemons;
using UserLoginProject.Domain.Interface.Pokemons;

namespace UserLoginProject.Domain.UseCase.Pokemons
{
    public class DeletePokemonUseCase : IDeletePokemon
    {
        private readonly CheckPokemon _checkPokemon;
        private readonly DeletePokemon _deletePokemon;
        public DeletePokemonUseCase(CheckPokemon checkPokemon, DeletePokemon deletePokemon)
        {
            _checkPokemon = checkPokemon;
            _deletePokemon = deletePokemon;
        }
        public async Task<bool> Delete(string idPokemon, Guid accountId) {
            var exist = await _checkPokemon.Check(idPokemon, accountId);
            if (!exist) return false;
            await _deletePokemon.Delete(idPokemon, accountId);
            return true;
        }
    }
}
