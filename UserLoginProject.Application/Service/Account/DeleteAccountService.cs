using UserLoginProject.Application.Interfaces.Account;
using UserLoginProject.Domain.Interface.Account;

namespace UserLoginProject.Application.Service.Account
{
    public class DeleteAccountService : IDeleteAccountService
    {
        private readonly IDeleteAccount _deleteAccount;
        public DeleteAccountService(IDeleteAccount deleteAccount)
        {
            _deleteAccount = deleteAccount;
        }
        public async Task Delete(Guid id)
        {
            await _deleteAccount.Delete(id);
        }
    }
}
