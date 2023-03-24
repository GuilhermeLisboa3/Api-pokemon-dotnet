using UserLoginProject.Domain.Entities;

namespace UserLoginProject.Domain.Contracts.Repository.Account
{
    public interface LoadAccountByEmail
    {
        Task<User> LoadByEmail(string email);
    }
}
