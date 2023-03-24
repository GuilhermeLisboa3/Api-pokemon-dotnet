using UserLoginProject.Domain.Contracts.Gateway;
using UserLoginProject.Domain.Contracts.Repository.Account;
using UserLoginProject.Domain.Entities;
using UserLoginProject.Domain.Interface.Account;

namespace UserLoginProject.Domain.UseCase.Account
{
    public class AddAccountUseCase : IAddAccount
    {
        private readonly CheckAccountByEmail _checkAccountByEmail;
        private readonly AddAccountRepo _addAccouny;
        private readonly Hash _hash;
        public AddAccountUseCase(CheckAccountByEmail checkAccountByEmail, AddAccountRepo addAccouny, Hash hash)
        {
            _checkAccountByEmail = checkAccountByEmail;
            _addAccouny = addAccouny;
            _hash = hash;
        }
        public async Task<User?> Add(User userModel)
        {
            var existe = await _checkAccountByEmail.CheckByEmail(userModel.Email);
            if (!existe)
            {
                var hashPassword = await _hash.Generate(userModel.Password);
                userModel.Password = hashPassword;
                var user = await _addAccouny.Add(userModel);
                return user;
            }
            return null;
        }
    }
}
