using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserLoginProject.Domain.Entities;

namespace UserLoginProject.Domain.Contracts.Repository.Pokemons
{
    public interface ListPokemonsRepo
    {
        Task<List<Pokemon>> ListPokemon(Guid accountId);
    }
}
