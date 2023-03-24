using UserLoginProject.Domain.Interface.Account;
using UserLoginProject.Domain.Interface.Pokemons;
using UserLoginProject.Domain.UseCase.Account;
using UserLoginProject.Domain.UseCase.Pokemons;

namespace UserLoginProject.Main.Factories
{
    public static class DomainModule
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            services
                .AddDomainServices();

            return services;
        }

        private static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            services.AddScoped<IAddAccount, AddAccountUseCase>();
            services.AddScoped<IAuthentication, AuthenticationUseCase>();
            services.AddScoped<IDeleteAccount, DeleteAccountUseCase>();

            services.AddScoped<IAddPokemon, AddPokemonUseCase>();
            services.AddScoped<IListPokemons, ListPokemonsUseCase>();
            services.AddScoped<IDeletePokemon, DeletePokemonUseCase>();

            return services;
        }
    }
}
