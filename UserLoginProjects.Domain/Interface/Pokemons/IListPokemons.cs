using UserLoginProject.Domain.Entities;

namespace UserLoginProject.Domain.Interface.Pokemons
{
    public interface IListPokemons
    {
        Task<List<Pokemon>> List(Guid accountId);
    }
}
