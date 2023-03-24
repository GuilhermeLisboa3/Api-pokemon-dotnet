using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLoginProject.Domain.Contracts.Repository.Pokemons
{
    public interface DeletePokemon
    {
        Task Delete(string idPokemon, Guid accountId);
    }
}
