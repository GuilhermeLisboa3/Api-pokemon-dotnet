using System.ComponentModel.DataAnnotations;

namespace UserLoginProject.Domain.Entities
{
    public class Pokemon
    {
        public Pokemon(string namePokemon, string photoPokemon, string idPokemon, string types, string urlSpecies)
        {
            NamePokemon = namePokemon;
            PhotoPokemon = photoPokemon;
            IdPokemon = idPokemon;
            UrlSpecies = urlSpecies;
            Types = types;
        }

        public Guid Id { get; set; }
        [Required]
        public string NamePokemon { get; set; }
        [Required]
        public string PhotoPokemon { get; set; }
        [Required]
        public string IdPokemon { get; set; }
        [Required]
        public string Types { get; set; }
        [Required]
        public string UrlSpecies { get; set; }
        [Required]
        public Guid AccountId { get; set; }
    }
}
