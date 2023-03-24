namespace UserLoginProject.Application.Interfaces.Pokemons
{
    public interface IDeletePokemonService
    {
        Task Delete(string idPokemon, Guid accountId);
    }
}
