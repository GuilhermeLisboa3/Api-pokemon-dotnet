using UserLoginProject.Application.DTOS.Input;
using UserLoginProject.Application.DTOS.Output;
using UserLoginProject.Application.Interfaces.Account;
using UserLoginProject.Domain.Interface.Account;

namespace UserLoginProject.Application.Service.Account
{
    public class AddAccountService : IAddAccountService
    {
        private readonly IAddAccount _addAccount;
        public AddAccountService(IAddAccount addAccount)
        {
            _addAccount = addAccount;
        }

        public async Task<UserOutput> Add(UserInput userModel)
        {
            var userInput = userModel.toEntity();
            var user = await _addAccount.Add(userInput);
            if (user != null) return UserOutput.FromEntity(user);
            return null;
        }
    }
}
