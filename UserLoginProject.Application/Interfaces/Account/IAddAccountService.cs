using UserLoginProject.Application.DTOS.Input;
using UserLoginProject.Application.DTOS.Output;

namespace UserLoginProject.Application.Interfaces.Account
{
    public interface IAddAccountService
    {
        Task<UserOutput> Add(UserInput user);
    }
}
