using UserLoginProject.Application.DTOS.Input;
using UserLoginProject.Application.Interfaces.Account;
using UserLoginProject.Domain.Interface.Account;

namespace UserLoginProject.Application.Service.Account
{
    public class LoginService : ILoginService
    {
        private readonly IAuthentication _authentication;
        public LoginService(IAuthentication authentication)
        {
            _authentication = authentication;
        }

        public async Task<string> Login(LoginUserInput user)
        {
            var token = await _authentication.Auth(user.Email, user.Password);
            return token;
        }
    }
}
