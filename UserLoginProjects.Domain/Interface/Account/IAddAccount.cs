using UserLoginProject.Domain.Entities;

namespace UserLoginProject.Domain.Interface.Account
{
    public interface IAddAccount
    {
        Task<User?> Add(User userModel);
    }
}
