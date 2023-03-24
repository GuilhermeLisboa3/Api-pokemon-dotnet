using UserLoginProject.Application.Interfaces.Account;
using UserLoginProject.Application.Interfaces.Pokemons;
using UserLoginProject.Application.Service.Account;
using UserLoginProject.Application.Service.Pokemons;

namespace UserLoginProject.Main.Factories
{
    public static class ApplicationModule
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services
                .AddApplicationServices();

            return services;
        }

        private static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IAddAccountService, AddAccountService>();
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IDeleteAccountService, DeleteAccountService>();

            services.AddScoped<IAddPokemonService, AddPokemonService>();
            services.AddScoped<IListPokemonsService, ListPokemonsService>();
            services.AddScoped<IDeletePokemonService, DeletePokemonService>();

            return services;
        }
    }
}
