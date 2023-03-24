using UserLoginProject.Domain.Contracts.Repository.Account;
using UserLoginProject.Domain.Interface.Account;

namespace UserLoginProject.Domain.UseCase.Account
{
    public class DeleteAccountUseCase : IDeleteAccount
    {
        private readonly CheckAccountById _checkAccountById;
        private readonly DeleteAccount _deleteAccount;
        public DeleteAccountUseCase(CheckAccountById checkAccountById, DeleteAccount deleteAccount)
        {
            _checkAccountById = checkAccountById;
            _deleteAccount = deleteAccount;
        }
        public async Task<bool> Delete(Guid id)
        {
            var exist = await _checkAccountById.CheckById(id);
            if (!exist) return false;
            await _deleteAccount.Delete(id);
            return true;
        }
    }
}
