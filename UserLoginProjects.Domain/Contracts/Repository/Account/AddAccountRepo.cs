using UserLoginProject.Domain.Entities;

namespace UserLoginProject.Domain.Contracts.Repository.Account
{
    public interface AddAccountRepo
    {
        Task<User> Add(User userModel);
    }
}
