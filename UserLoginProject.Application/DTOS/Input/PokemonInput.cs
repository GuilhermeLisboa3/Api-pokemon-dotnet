using UserLoginProject.Domain.Entities;

namespace UserLoginProject.Application.DTOS.Input
{
    public class PokemonInput
    {
        public string NamePokemon { get; set; }
        public string PhotoPokemon { get; set; }
        public string IdPokemon { get; set; }
        public string Types { get; set; }
        public string UrlSpecies { get; set; }

        public Pokemon toEntity()
            => new Pokemon(NamePokemon, PhotoPokemon, IdPokemon, Types, UrlSpecies);
    }
}

