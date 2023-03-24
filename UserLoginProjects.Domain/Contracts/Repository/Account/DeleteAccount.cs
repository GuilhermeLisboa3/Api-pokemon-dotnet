using System.Runtime.CompilerServices;

namespace UserLoginProject.Domain.Contracts.Repository.Account
{
    public interface DeleteAccount
    {
        Task Delete(Guid id);
    }
}
