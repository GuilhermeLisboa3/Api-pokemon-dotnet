namespace UserLoginProject.Domain.Contracts.Repository.Pokemons
{
    public interface CheckPokemon
    {
        Task<bool> Check(string idPokemon, Guid accountId);
    }
}
