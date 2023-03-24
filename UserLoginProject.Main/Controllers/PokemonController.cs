using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UserLoginProject.Application.DTOS.Input;
using UserLoginProject.Application.Interfaces.Account;
using UserLoginProject.Application.Interfaces.Pokemons;
using UserLoginProject.Domain.Contracts.Repository.Account;

namespace UserLoginProject.Main.Controllers
{
    [ApiController]
    [Route("")]
    public class PokemonController : ControllerBase
    {
        private readonly IAddPokemonService _addPokemon;
        private readonly IListPokemonsService _listPokemons;
        private readonly IDeletePokemonService _deletePokemon;

        public PokemonController(IAddPokemonService addPokemon, IListPokemonsService listPokemons, IDeletePokemonService deletePokemon)
        { 
            _addPokemon = addPokemon;
            _listPokemons = listPokemons;
            _deletePokemon = deletePokemon;
        }

        [Authorize]
        [HttpPost]
        [Route("pokemon")]
        public async Task<IActionResult> Add([FromBody] PokemonInput model)
        {
            if (!ModelState.IsValid) return BadRequest();
            var accountId = new Guid(User.Identity.Name);
            var pokemon = await _addPokemon.Add(model, accountId);
            if (pokemon == null) return BadRequest();
            return Ok(pokemon);
        }

        [Authorize]
        [HttpGet]
        [Route("pokemons")]
        public async Task<IActionResult> List()
        {
            var accountId = new Guid(User.Identity.Name);
            var pokemon = await _listPokemons.List( accountId);
            return Ok(pokemon);
        }

        [Authorize]
        [HttpDelete]
        [Route("pokemon/{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var accountId = new Guid(User.Identity.Name);
            await _deletePokemon.Delete(idPokemon: id, accountId);
            return NoContent();
        }
    }
}
