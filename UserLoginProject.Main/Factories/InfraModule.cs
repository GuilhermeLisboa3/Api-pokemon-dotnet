using UserLoginProject.Domain.Contracts.Gateway;
using UserLoginProject.Domain.Contracts.Repository.Account;
using UserLoginProject.Domain.Contracts.Repository.Pokemons;
using UserLoginProject.Infra.Database.Repositories;
using UserLoginProject.Infra.Gateway;

namespace UserLoginProject.Main.Factories
{
    public static class InfraModule
    {
        public static IServiceCollection AddInfra(this IServiceCollection services)
        {
            services
                .AddInfraRepository()
                .AddInfraGateway();

            return services;
        }

        private static IServiceCollection AddInfraRepository(this IServiceCollection services)
        {
            services.AddScoped<CheckAccountByEmail, AccountRepository>();
            services.AddScoped<AddAccountRepo, AccountRepository>();
            services.AddScoped<LoadAccountByEmail, AccountRepository>();
            services.AddScoped<CheckAccountById, AccountRepository>();
            services.AddScoped<DeleteAccount, AccountRepository>();

            services.AddScoped<CheckPokemon, PokemonRepository>();
            services.AddScoped<AddPokemon, PokemonRepository>();
            services.AddScoped<ListPokemonsRepo, PokemonRepository>();
            services.AddScoped<DeletePokemon, PokemonRepository>();

            return services;
        }
        private static IServiceCollection AddInfraGateway(this IServiceCollection services)
        {
            services.AddScoped<Hash, HashAdapter>();
            services.AddScoped<Token, TokenAdapter>();

            return services;
        }
    }
}
