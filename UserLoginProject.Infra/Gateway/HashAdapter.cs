using System.Security.Cryptography;
using UserLoginProject.Domain.Contracts.Gateway;

namespace UserLoginProject.Infra.Gateway
{
    public class HashAdapter : Hash
    {
        public Task<string> Generate(string plaintext)
        {
            var hashedPassword = BCrypt.Net.BCrypt.HashPassword(plaintext);
            return Task.FromResult(hashedPassword);
        }

        public Task<bool> Verify(string plaintext, string digest)
        {
            bool validPassword = BCrypt.Net.BCrypt.Verify(plaintext, digest);
            return Task.FromResult(validPassword);
        }
    }
}
