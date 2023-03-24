using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using UserLoginProject.Domain.Contracts.Gateway;

namespace UserLoginProject.Infra.Gateway
{
    public class TokenAdapter : Token
    {
        public Task<string> Generate(string key)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var secret = Encoding.ASCII.GetBytes("Joijaoisbndjfoiasu2134i23nro2fas");
            var descriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] {
            new Claim(ClaimTypes.Name, key.ToString())
          }),
                Expires = DateTime.UtcNow.AddHours(5),
                SigningCredentials = new SigningCredentials(
                new SymmetricSecurityKey(secret), SecurityAlgorithms.HmacSha256Signature
              )
            };
            var token = tokenHandler.CreateToken(descriptor);
            return Task.FromResult(tokenHandler.WriteToken(token));
        }
    }
}
