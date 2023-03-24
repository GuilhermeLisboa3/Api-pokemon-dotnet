using UserLoginProject.Domain.Entities;

namespace UserLoginProject.Application.DTOS.Input
{
    public class UserInput
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User toEntity()
            => new User(Name, Email, Password);
    }
}
