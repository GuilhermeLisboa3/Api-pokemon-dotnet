using UserLoginProject.Domain.Entities;

namespace UserLoginProject.Application.DTOS.Output
{
    public class PokemonOutput
    {
        public PokemonOutput(Guid id, string namePokemon, string photoPokemon, string idPokemon, string types, string urlSpecies, Guid accountId)
        {
            Id = id;
            NamePokemon = namePokemon;
            PhotoPokemon = photoPokemon;
            IdPokemon = idPokemon;
            UrlSpecies = urlSpecies;
            AccountId = accountId;
            Types = types;
        }

        public Guid Id { get; private set; }
        public string NamePokemon { get; set; }
        public string PhotoPokemon { get; set; }
        public string IdPokemon { get; set; }
        public string Types { get; set; }
        public string UrlSpecies { get; set; }
        public Guid AccountId { get; set; }

        public static PokemonOutput FromEntity(Pokemon pokemon)
        {
            return new PokemonOutput(pokemon.Id, pokemon.NamePokemon, pokemon.PhotoPokemon, pokemon.IdPokemon, pokemon.Types, pokemon.UrlSpecies, pokemon.AccountId);
        }
    }
}
