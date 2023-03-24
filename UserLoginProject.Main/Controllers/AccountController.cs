using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UserLoginProject.Application.DTOS.Input;
using UserLoginProject.Application.Interfaces.Account;

namespace UserLoginProject.Main.Controllers
{
    [ApiController]
    [Route("")]
    public class AccountController : ControllerBase
    {
        private readonly IAddAccountService _addAccount;
        private readonly ILoginService _login;
        private readonly IDeleteAccountService _deleteAccount;

        public AccountController(IAddAccountService addAccount, ILoginService login, IDeleteAccountService deleteAccount)
        {
            _addAccount = addAccount;
            _login = login;
            _deleteAccount = deleteAccount;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> SigUp([FromBody] UserInput model)
        {
            if (!ModelState.IsValid) return BadRequest();
            var user = await _addAccount.Add(model);
            if (user == null) return BadRequest();
            return Ok(user);
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginUserInput user)
        {
            if (!ModelState.IsValid) return BadRequest();
            var token = await _login.Login(user);
            if (token == null) return Unauthorized();
            return Ok(token);
        }

        [Authorize]
        [HttpDelete]
        [Route("user")]
        public async Task<IActionResult> Delete()
        {
            var id = new Guid(User.Identity.Name);
            await _deleteAccount.Delete(id);
            return NoContent();
        }
    }
}