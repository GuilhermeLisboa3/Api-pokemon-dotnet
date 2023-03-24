using UserLoginProject.Application.DTOS.Input;

namespace UserLoginProject.Application.Interfaces.Account
{
    public interface ILoginService
    {
        Task<string> Login(LoginUserInput user);
    }
}
