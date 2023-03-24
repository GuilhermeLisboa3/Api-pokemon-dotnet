using UserLoginProject.Domain.Contracts.Gateway;
using UserLoginProject.Domain.Contracts.Repository.Account;
using UserLoginProject.Domain.Interface.Account;

namespace UserLoginProject.Domain.UseCase.Account
{
    public class AuthenticationUseCase : IAuthentication
    {
        private readonly LoadAccountByEmail _loadAccountByEmail;
        private readonly Hash _hash;
        private readonly Token _token;
        public AuthenticationUseCase(LoadAccountByEmail loadAccountByEmail, Hash hash, Token token)
        {
            _loadAccountByEmail = loadAccountByEmail;
            _hash = hash;
            _token = token;
        }
        public async Task<string> Auth(string email, string password)
        {
            var account = await _loadAccountByEmail.LoadByEmail(email);
            if (account != null)
            {
                var isEqual = await _hash.Verify(password, account.Password);
                if (isEqual)
                {
                    return await _token.Generate(account.Id.ToString());
                }
            }
            return null;
        }
    }
}
