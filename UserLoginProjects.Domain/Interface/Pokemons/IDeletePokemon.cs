namespace UserLoginProject.Domain.Interface.Pokemons
{
    public interface IDeletePokemon
    {
        Task<bool> Delete(string idPokemon, Guid accountId);
    }
}
